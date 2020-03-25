using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Word_Password_Brute_Force
{
    public partial class Main : Form
    {

        static string allowedstr = null;
        static char[] AllowedCC = null;
        int AllowedlattertIdx = -1;
        object SyncLockerobjNewPassword = new object();
        private char[] PasswordToVerify;

        private string FileName = null;
        private System.Collections.Generic.List<System.Threading.Thread> TTCll = null;
        private DateTime StartDtTm;

        object SyncLockerobjStopSearch = new object();
        private bool MeStopSearch = false;


        public Main()
        {
            InitializeComponent();

            ExtimedTimeTxt_Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnBrowse.Enabled = false;

            allowedstr = AllowedCharsToString();
            AllowedCC = allowedstr.ToCharArray();
            AllowedlattertIdx = allowedstr.Length - 1;

            FileName = FileNameTxt.Text;

            StartDtTm = DateTime.UtcNow;

            // --- set first password to check
            int PwMinLen = int.Parse(PwMinLenTxt.Text);
            PasswordToVerify = new char[PwMinLen];
            PasswordToVerify = new string(AllowedCC[0], PwMinLen).ToCharArray();

            int ThreadToUse = int.Parse(MaxTasksTxt.Text);
            ThreadPanel_Create(ThreadToUse);


            TTCll = new System.Collections.Generic.List<System.Threading.Thread>();
            for (int numt = 0; numt < ThreadToUse; numt++)
            {
                TextBox NumTxt = (TextBox)(EsecuzioneTLP.Controls["NumThread" + numt.ToString("00") + "Txt"]);
                var T = new System.Threading.Thread(() => { Runner(NumTxt); });
                T.Priority = System.Threading.ThreadPriority.Lowest;
                T.Start();
                TTCll.Add(T);
            }
        }

        private void ThreadPanel_Create(int Tot)
        {

            EsecuzioneTLP.ColumnCount = Tot;

            // the first column already exists
            {
                ColumnStyle ClnSt = new ColumnStyle(SizeType.Percent, ((float)1 / Tot * 100));
                EsecuzioneTLP.ColumnStyles[0] = ClnSt;
            }


            for (int Idx = 0 + 1; Idx < Tot; Idx++)
            {
                ColumnStyle ClnSt = new ColumnStyle(SizeType.Percent, ((float)1 / Tot * 100));
                int i = EsecuzioneTLP.ColumnStyles.Add(ClnSt);
            }


            for (int Idx = 0; Idx < Tot; Idx++)
            {
                // r 1
                EsecuzioneTLP.Controls.Add(new Label() { Text = Idx.ToString("00") }, Idx, 0);
                // r 2
                TextBox NumTxt = new TextBox() { TextAlign = HorizontalAlignment.Right, Width = 50, Name = "NumThread" + Idx.ToString("00") + "Txt" };
                EsecuzioneTLP.Controls.Add(NumTxt, Idx, 1);
            }
        }


        void Runner(TextBox NumTxt)
        {
            var AA = new System.Action<string>((s) => { NumTxt.Text = s; });
            //--- App Word
            NumTxt.Invoke(AA, "word");
            var WApp = new Microsoft.Office.Interop.Word.Application();
            NumTxt.Invoke(AA, string.Empty);

            while (!StopSearch())
            {
                string test = new string(PasswordNext());

                NumTxt.Invoke(AA, test);

                {
                    Microsoft.Office.Interop.Word.Document WDoc = null;
                    try
                    {
                        WDoc = WApp.Documents.Open(FileName, PasswordDocument: test, ReadOnly: true);
                        StopSearch(true);

                        Achivied(test);

                        WDoc.Close();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(WDoc);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("La password non è corretta. Word non può aprire il documento."))
                        {
                            // ok
                        }
                        else
                        {
                            // errore inatteso
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

            }

            if (WApp != null)
            {
                try { WApp.Quit(); } finally { }
                try { System.Runtime.InteropServices.Marshal.ReleaseComObject(WApp); } finally { }
            }
        }

        private char[] PasswordNext()
        {
            char[] GiveBack;

            lock (SyncLockerobjNewPassword)
            {
                // --- password to verify
                GiveBack = new char[PasswordToVerify.Length];

                // --- password to prepare to next round
                PasswordToVerify.CopyTo(GiveBack, 0);
                //  prepare next pwd 
                bool riporto = false;
                for (int i = PasswordToVerify.Length - 1; i >= 0; i--)
                {
 
                    if (PasswordToVerify[i] != AllowedCC[AllowedlattertIdx])
                    {
 
                        PasswordToVerify[i] = AllowedCC[(allowedstr.IndexOf(PasswordToVerify[i]) + 1)];
                        riporto = false;
                        break;
                    }
                    else
                    {
 
                        PasswordToVerify[i] = AllowedCC[0];
                        riporto = true;
                    }
                }
                // --- insert new starting char on left side
                if (riporto)
                {
                    char[] tmp = new char[PasswordToVerify.Length];
                    PasswordToVerify.CopyTo(tmp, 0);

                    PasswordToVerify = new char[PasswordToVerify.Length + 1];
                    PasswordToVerify[0] = AllowedCC[0];
                    tmp.CopyTo(PasswordToVerify, 1);
                }
            }

            return GiveBack;
        }

        private bool StopSearch(bool stopper = false)
        {
            bool yn;

            lock (SyncLockerobjStopSearch)
            {
                if (stopper)
                {
                    MeStopSearch = stopper;
                }

                yn = MeStopSearch;
            }

            return yn;
        }


        private void Achivied(string pw)
        {
            PasswordTxt.Invoke(new System.Action(() => { PasswordTxt.Text = pw; }));
            try
            {
                DateTime NowDtTm = DateTime.UtcNow;
                TimeNeededTxt.Invoke(new System.Action(() => { TimeNeededTxt.Text = (NowDtTm - StartDtTm).ToString(@"d\g\g\:hh\h\h\:mm\m\m\:ss\s\s"); }));
                TimeNeededTxt.Invoke(new System.Action(() => { StartTxt.Text = (StartDtTm).ToString(); }));
                TimeNeededTxt.Invoke(new System.Action(() => { EndTxt.Text = (NowDtTm).ToString(); }));
                this.BackColor = Color.LightGreen;
            }
            finally
            { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LunghezzaMassimaTxt_TextChanged(object sender, EventArgs e)
        {
            ExtimedTimeTxt_Populate();
        }

        private void MaxTasksTxt_TextChanged(object sender, EventArgs e)
        {
            ExtimedTimeTxt_Populate();
        }

        private void ExtimedTimeTxt_Populate()
        {
            ExtimedTimeTxt.Text = string.Empty;

            if (int.TryParse(PwMaxLenTxt.Text, out int L) && int.TryParse(MaxTasksTxt.Text, out int P))
            {
                // A-Z  +  a-z  +  0-9   (26+26+10=62) ->   238.328 combinations
                // 4 thread su 238.328 combinations  ->  2h,30m  -> 1.500 test/minut
                // 1.500 / 4 thread = 400 test/processore/minuto
                double minutes = Math.Pow(AllowedCharsToString().Length, L) / (P * 400);
                TimeSpan TS = new TimeSpan(0, (int)minutes, 0);
                ExtimedTimeTxt.Text = (TS.TotalDays > 5 ? ((int)(TS.TotalDays)).ToString() + "gg " : TS.ToString().Replace(".", "gg "));
            }
        }


        string AllowedCharsToString()
        {
            return (UppercaseChk.Checked ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : string.Empty)
                        + (LowercaseChk.Checked ? "abcdefghijklmnopqrstuvwxyz" : string.Empty)
                        + (NumbersChk.Checked ? "0123456789" : string.Empty)
                        ;
        }

        private void UppercaseChk_CheckedChanged(object sender, EventArgs e)
        {
            ExtimedTimeTxt_Populate();
        }

        private void LowercaseChk_CheckedChanged(object sender, EventArgs e)
        {
            ExtimedTimeTxt_Populate();
        }

        private void NumbersChk_CheckedChanged(object sender, EventArgs e)
        {
            ExtimedTimeTxt_Populate();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileNameTxt.Text = openFileDialog1.FileName;
                    
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
