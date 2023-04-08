namespace Movie_Member
{
    partial class Member_LogIn_Register
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Link_forgetPassword = new System.Windows.Forms.LinkLabel();
            this.Btn_Demo = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabPage();
            this.Btn_Demo2 = new System.Windows.Forms.Button();
            this.Combo_Gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Time_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Txt_EmailR = new System.Windows.Forms.TextBox();
            this.Txt_NameR = new System.Windows.Forms.TextBox();
            this.Txt_IDCardR = new System.Windows.Forms.TextBox();
            this.Txt_PasswordR = new System.Windows.Forms.TextBox();
            this.Txt_PhoneR = new System.Windows.Forms.TextBox();
            this.Lab_Login = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TabControl);
            this.tabControl1.Location = new System.Drawing.Point(118, 125);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 486);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Cancel);
            this.tabPage1.Controls.Add(this.Link_forgetPassword);
            this.tabPage1.Controls.Add(this.Btn_Demo);
            this.tabPage1.Controls.Add(this.Btn_Login);
            this.tabPage1.Controls.Add(this.Txt_Password);
            this.tabPage1.Controls.Add(this.Txt_Account);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(345, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Link_forgetPassword
            // 
            this.Link_forgetPassword.AutoSize = true;
            this.Link_forgetPassword.Location = new System.Drawing.Point(217, 154);
            this.Link_forgetPassword.Name = "Link_forgetPassword";
            this.Link_forgetPassword.Size = new System.Drawing.Size(60, 17);
            this.Link_forgetPassword.TabIndex = 5;
            this.Link_forgetPassword.TabStop = true;
            this.Link_forgetPassword.Text = "忘記密碼";
            this.Link_forgetPassword.Visible = false;
            this.Link_forgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_forgetPassword_LinkClicked);
            // 
            // Btn_Demo
            // 
            this.Btn_Demo.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Demo.Location = new System.Drawing.Point(130, 253);
            this.Btn_Demo.Name = "Btn_Demo";
            this.Btn_Demo.Size = new System.Drawing.Size(85, 32);
            this.Btn_Demo.TabIndex = 4;
            this.Btn_Demo.Text = "Demo";
            this.Btn_Demo.UseVisualStyleBackColor = false;
            this.Btn_Demo.Click += new System.EventHandler(this.Btn_Demo_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Login.Location = new System.Drawing.Point(79, 203);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(85, 32);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "登入";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(75, 122);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(195, 25);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            // 
            // Txt_Account
            // 
            this.Txt_Account.Location = new System.Drawing.Point(75, 72);
            this.Txt_Account.Name = "Txt_Account";
            this.Txt_Account.Size = new System.Drawing.Size(195, 25);
            this.Txt_Account.TabIndex = 1;
            this.Txt_Account.Enter += new System.EventHandler(this.Txt_Account_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Btn_Demo2);
            this.TabControl.Controls.Add(this.Combo_Gender);
            this.TabControl.Controls.Add(this.label2);
            this.TabControl.Controls.Add(this.Time_BirthDate);
            this.TabControl.Controls.Add(this.lab_Gender);
            this.TabControl.Controls.Add(this.Btn_Register);
            this.TabControl.Controls.Add(this.Txt_EmailR);
            this.TabControl.Controls.Add(this.Txt_NameR);
            this.TabControl.Controls.Add(this.Txt_IDCardR);
            this.TabControl.Controls.Add(this.Txt_PasswordR);
            this.TabControl.Controls.Add(this.Txt_PhoneR);
            this.TabControl.Location = new System.Drawing.Point(4, 26);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Windows.Forms.Padding(4);
            this.TabControl.Size = new System.Drawing.Size(345, 456);
            this.TabControl.TabIndex = 1;
            this.TabControl.Text = "註冊";
            this.TabControl.UseVisualStyleBackColor = true;
            // 
            // Btn_Demo2
            // 
            this.Btn_Demo2.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Demo2.Location = new System.Drawing.Point(125, 405);
            this.Btn_Demo2.Name = "Btn_Demo2";
            this.Btn_Demo2.Size = new System.Drawing.Size(90, 32);
            this.Btn_Demo2.TabIndex = 14;
            this.Btn_Demo2.Text = "Demo";
            this.Btn_Demo2.UseVisualStyleBackColor = false;
            this.Btn_Demo2.Click += new System.EventHandler(this.Btn_Demo2_Click);
            // 
            // Combo_Gender
            // 
            this.Combo_Gender.FormattingEnabled = true;
            this.Combo_Gender.Items.AddRange(new object[] {
            "男",
            "女",
            "非二元性別"});
            this.Combo_Gender.Location = new System.Drawing.Point(63, 319);
            this.Combo_Gender.Name = "Combo_Gender";
            this.Combo_Gender.Size = new System.Drawing.Size(211, 25);
            this.Combo_Gender.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "生日";
            // 
            // Time_BirthDate
            // 
            this.Time_BirthDate.Location = new System.Drawing.Point(63, 264);
            this.Time_BirthDate.Name = "Time_BirthDate";
            this.Time_BirthDate.Size = new System.Drawing.Size(211, 25);
            this.Time_BirthDate.TabIndex = 11;
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.Location = new System.Drawing.Point(60, 299);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(34, 17);
            this.lab_Gender.TabIndex = 9;
            this.lab_Gender.Text = "性別";
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Register.Location = new System.Drawing.Point(125, 367);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(90, 32);
            this.Btn_Register.TabIndex = 10;
            this.Btn_Register.Text = "註冊";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Txt_EmailR
            // 
            this.Txt_EmailR.Location = new System.Drawing.Point(63, 208);
            this.Txt_EmailR.Name = "Txt_EmailR";
            this.Txt_EmailR.Size = new System.Drawing.Size(211, 25);
            this.Txt_EmailR.TabIndex = 4;
            this.Txt_EmailR.Text = "請輸入Email";
            this.Txt_EmailR.Enter += new System.EventHandler(this.Txt_EmailR_Enter);
            // 
            // Txt_NameR
            // 
            this.Txt_NameR.Location = new System.Drawing.Point(63, 164);
            this.Txt_NameR.Name = "Txt_NameR";
            this.Txt_NameR.Size = new System.Drawing.Size(211, 25);
            this.Txt_NameR.TabIndex = 3;
            this.Txt_NameR.Text = "請輸入姓名";
            this.Txt_NameR.Enter += new System.EventHandler(this.Txt_NameR_Enter);
            // 
            // Txt_IDCardR
            // 
            this.Txt_IDCardR.Location = new System.Drawing.Point(63, 122);
            this.Txt_IDCardR.Name = "Txt_IDCardR";
            this.Txt_IDCardR.Size = new System.Drawing.Size(211, 25);
            this.Txt_IDCardR.TabIndex = 2;
            this.Txt_IDCardR.Text = "請輸入身份證字號";
            this.Txt_IDCardR.Enter += new System.EventHandler(this.Txt_IDCardR_Enter);
            // 
            // Txt_PasswordR
            // 
            this.Txt_PasswordR.Location = new System.Drawing.Point(63, 80);
            this.Txt_PasswordR.Name = "Txt_PasswordR";
            this.Txt_PasswordR.Size = new System.Drawing.Size(211, 25);
            this.Txt_PasswordR.TabIndex = 1;
            this.Txt_PasswordR.Text = "請輸入密碼";
            this.Txt_PasswordR.Enter += new System.EventHandler(this.Txt_PasswordR_Enter);
            // 
            // Txt_PhoneR
            // 
            this.Txt_PhoneR.Location = new System.Drawing.Point(63, 37);
            this.Txt_PhoneR.Name = "Txt_PhoneR";
            this.Txt_PhoneR.Size = new System.Drawing.Size(211, 25);
            this.Txt_PhoneR.TabIndex = 0;
            this.Txt_PhoneR.Text = "請輸入電話(電話即為帳號)";
            this.Txt_PhoneR.Enter += new System.EventHandler(this.Txt_PhoneR_Enter);
            // 
            // Lab_Login
            // 
            this.Lab_Login.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Login.Location = new System.Drawing.Point(195, 51);
            this.Lab_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Login.Name = "Lab_Login";
            this.Lab_Login.Size = new System.Drawing.Size(201, 48);
            this.Lab_Login.TabIndex = 1;
            this.Lab_Login.Text = "文青影城";
            this.Lab_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Cancel.Location = new System.Drawing.Point(185, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 32);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Member_LogIn_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(589, 635);
            this.Controls.Add(this.Lab_Login);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Member_LogIn_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入/註冊";
            this.Load += new System.EventHandler(this.Member_LogIn_Register_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TabControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Txt_Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabControl;
        private System.Windows.Forms.Label Lab_Login;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_PhoneR;
        private System.Windows.Forms.Button Btn_Demo;
        private System.Windows.Forms.TextBox Txt_EmailR;
        private System.Windows.Forms.TextBox Txt_NameR;
        private System.Windows.Forms.TextBox Txt_IDCardR;
        private System.Windows.Forms.TextBox Txt_PasswordR;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.LinkLabel Link_forgetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Time_BirthDate;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.ComboBox Combo_Gender;
        private System.Windows.Forms.Button Btn_Demo2;
        private System.Windows.Forms.Button btn_Cancel;
    }
}