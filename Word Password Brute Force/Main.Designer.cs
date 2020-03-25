namespace Word_Password_Brute_Force
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label11 = new System.Windows.Forms.Label();
            this.FileNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EsecuzioneTLP = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeNeededTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExtimedTimeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTasksTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PwMinLenTxt = new System.Windows.Forms.TextBox();
            this.PwMaxLenTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UppercaseChk = new System.Windows.Forms.CheckBox();
            this.NumbersChk = new System.Windows.Forms.CheckBox();
            this.LowercaseChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "File";
            // 
            // FileNameTxt
            // 
            this.FileNameTxt.Location = new System.Drawing.Point(12, 21);
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.Size = new System.Drawing.Size(421, 20);
            this.FileNameTxt.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox5.Controls.Add(this.EsecuzioneTLP);
            this.groupBox5.Location = new System.Drawing.Point(12, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 80);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Running threads";
            // 
            // EsecuzioneTLP
            // 
            this.EsecuzioneTLP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EsecuzioneTLP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EsecuzioneTLP.ColumnCount = 1;
            this.EsecuzioneTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EsecuzioneTLP.Location = new System.Drawing.Point(6, 20);
            this.EsecuzioneTLP.Name = "EsecuzioneTLP";
            this.EsecuzioneTLP.RowCount = 2;
            this.EsecuzioneTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.EsecuzioneTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.EsecuzioneTLP.Size = new System.Drawing.Size(498, 54);
            this.EsecuzioneTLP.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.EndTxt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.StartTxt);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TimeNeededTxt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.PasswordTxt);
            this.groupBox4.Location = new System.Drawing.Point(15, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 64);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "End of job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "End Time";
            // 
            // EndTxt
            // 
            this.EndTxt.BackColor = System.Drawing.SystemColors.Info;
            this.EndTxt.Location = new System.Drawing.Point(261, 32);
            this.EndTxt.Name = "EndTxt";
            this.EndTxt.ReadOnly = true;
            this.EndTxt.Size = new System.Drawing.Size(115, 20);
            this.EndTxt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start time";
            // 
            // StartTxt
            // 
            this.StartTxt.BackColor = System.Drawing.SystemColors.Info;
            this.StartTxt.Location = new System.Drawing.Point(140, 32);
            this.StartTxt.Name = "StartTxt";
            this.StartTxt.ReadOnly = true;
            this.StartTxt.Size = new System.Drawing.Size(115, 20);
            this.StartTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time elapsed";
            // 
            // TimeNeededTxt
            // 
            this.TimeNeededTxt.BackColor = System.Drawing.SystemColors.Info;
            this.TimeNeededTxt.Location = new System.Drawing.Point(382, 32);
            this.TimeNeededTxt.Name = "TimeNeededTxt";
            this.TimeNeededTxt.ReadOnly = true;
            this.TimeNeededTxt.Size = new System.Drawing.Size(122, 20);
            this.TimeNeededTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.SystemColors.Info;
            this.PasswordTxt.Location = new System.Drawing.Point(9, 32);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.ReadOnly = true;
            this.PasswordTxt.Size = new System.Drawing.Size(125, 20);
            this.PasswordTxt.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExtimedTimeTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.MaxTasksTxt);
            this.groupBox3.Location = new System.Drawing.Point(356, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 130);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elaboration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "(on a Intel i5, 2 GHz)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Extmtd time to accomplish";
            // 
            // ExtimedTimeTxt
            // 
            this.ExtimedTimeTxt.BackColor = System.Drawing.SystemColors.Info;
            this.ExtimedTimeTxt.Location = new System.Drawing.Point(6, 74);
            this.ExtimedTimeTxt.Name = "ExtimedTimeTxt";
            this.ExtimedTimeTxt.ReadOnly = true;
            this.ExtimedTimeTxt.Size = new System.Drawing.Size(153, 20);
            this.ExtimedTimeTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Core to use";
            // 
            // MaxTasksTxt
            // 
            this.MaxTasksTxt.Location = new System.Drawing.Point(9, 35);
            this.MaxTasksTxt.Name = "MaxTasksTxt";
            this.MaxTasksTxt.Size = new System.Drawing.Size(52, 20);
            this.MaxTasksTxt.TabIndex = 6;
            this.MaxTasksTxt.Text = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 130);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.PwMinLenTxt);
            this.groupBox6.Controls.Add(this.PwMaxLenTxt);
            this.groupBox6.Location = new System.Drawing.Point(181, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 89);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max";
            // 
            // PwMinLenTxt
            // 
            this.PwMinLenTxt.Location = new System.Drawing.Point(9, 32);
            this.PwMinLenTxt.Name = "PwMinLenTxt";
            this.PwMinLenTxt.Size = new System.Drawing.Size(52, 20);
            this.PwMinLenTxt.TabIndex = 4;
            this.PwMinLenTxt.Text = "1";
            this.PwMinLenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PwMaxLenTxt
            // 
            this.PwMaxLenTxt.Location = new System.Drawing.Point(67, 32);
            this.PwMaxLenTxt.Name = "PwMaxLenTxt";
            this.PwMaxLenTxt.Size = new System.Drawing.Size(52, 20);
            this.PwMaxLenTxt.TabIndex = 4;
            this.PwMaxLenTxt.Text = "5";
            this.PwMaxLenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UppercaseChk);
            this.groupBox1.Controls.Add(this.NumbersChk);
            this.groupBox1.Controls.Add(this.LowercaseChk);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Char set";
            // 
            // UppercaseChk
            // 
            this.UppercaseChk.AutoSize = true;
            this.UppercaseChk.Location = new System.Drawing.Point(6, 19);
            this.UppercaseChk.Name = "UppercaseChk";
            this.UppercaseChk.Size = new System.Drawing.Size(99, 17);
            this.UppercaseChk.TabIndex = 9;
            this.UppercaseChk.Text = "uppercase (AZ)";
            this.UppercaseChk.UseVisualStyleBackColor = true;
            // 
            // NumbersChk
            // 
            this.NumbersChk.AutoSize = true;
            this.NumbersChk.Checked = true;
            this.NumbersChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumbersChk.Location = new System.Drawing.Point(6, 65);
            this.NumbersChk.Name = "NumbersChk";
            this.NumbersChk.Size = new System.Drawing.Size(87, 17);
            this.NumbersChk.TabIndex = 9;
            this.NumbersChk.Text = "numbers (09)";
            this.NumbersChk.UseVisualStyleBackColor = true;
            // 
            // LowercaseChk
            // 
            this.LowercaseChk.AutoSize = true;
            this.LowercaseChk.Location = new System.Drawing.Point(6, 42);
            this.LowercaseChk.Name = "LowercaseChk";
            this.LowercaseChk.Size = new System.Drawing.Size(94, 17);
            this.LowercaseChk.TabIndex = 9;
            this.LowercaseChk.Text = "lowercase (az)";
            this.LowercaseChk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(393, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Find password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(440, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 408);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FileNameTxt);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Password Brute Force";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FileNameTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel EsecuzioneTLP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimeNeededTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExtimedTimeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTasksTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PwMinLenTxt;
        private System.Windows.Forms.TextBox PwMaxLenTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox UppercaseChk;
        private System.Windows.Forms.CheckBox NumbersChk;
        private System.Windows.Forms.CheckBox LowercaseChk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
    }
}

