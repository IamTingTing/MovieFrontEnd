using Movie_Member;
using MovieFrontEnd;
using MovieOrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Movie_Member
{
    public partial class Member_LogIn_Register : Form
    {
        public Member_LogIn_Register()
        {
            InitializeComponent();

            this.ControlBox = false;

        }

        public string Member
        {
            get {return Txt_Account.Text;}
        }
        MovieEntities movieEntities = new MovieEntities();
        Boolean textboxHasText = false;

        public delegate void FormLogIn();
        public event FormLogIn frmLogIn;
        private void Btn_Login_Click(object sender, EventArgs e)
        {

            bool result = this.movieEntities.Members.Any(p => p.Phone == Txt_Account.Text);
            bool resultP = this.movieEntities.Members.Any(p => p.Password == Txt_Password.Text);

            if (Txt_Account.Text != "" && Txt_Password.Text != "")
            {
                if (result && resultP)
                {
                    MessageBox.Show("登入成功");
                    
                    //frmLogIn();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼輸入錯誤，請重新輸入", "登入", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (Txt_Account.Text == "")
            {
                MessageBox.Show("請輸入帳號!", "登入", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_Account.Text != "" && Txt_Password.Text == "")
            {
                MessageBox.Show("請輸入密碼!", "登入", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Demo_Click(object sender, EventArgs e)
        {
            Txt_Account.Text = "921038103";
            Txt_Password.PasswordChar = '*';
            Txt_Password.Text = "JN462c69";
        }
        
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (Txt_PhoneR.Text != "" && Txt_PasswordR.Text != "" && Txt_EmailR.Text != "" && Txt_IDCardR.Text != "" &&
         Txt_NameR.Text != "")
            {
                Member member = new Member
                {
                    Phone = Txt_PhoneR.Text,
                    Password = Txt_PasswordR.Text,
                    Name = Txt_NameR.Text,
                    IDCardNumber = Txt_IDCardR.Text,
                    Email = Txt_EmailR.Text,
                    BirthDate = Time_BirthDate.Value,
                    GenderID = Combo_Gender.SelectedIndex + 1,
                    MembershipID = 3,
                    CreatedDate = DateTime.Now,
                    Nickname = "",
                };
                this.movieEntities.Members.Add(member);


                this.movieEntities.SaveChanges();
                if (member != null)
                {
                    MessageBox.Show("註冊成功，請重新登錄");
                    tabControl1.SelectedIndex = 0;
                }
            }
            else if (Txt_PhoneR.Text == "")
            {
                MessageBox.Show("請輸入電話（電話即為帳號）!", "註冊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Txt_PhoneR.Text != "" && Txt_PasswordR.Text == "")
            {
                MessageBox.Show("請輸入密碼!", "註冊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // todo if沒有輸入&格式驗證
        }

        private void Link_forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Member_LogIn_Register_Load(object sender, EventArgs e)
        {
            if (Txt_Account.Text == "" || Txt_Password.Text == "" || Txt_PhoneR.Text == "" ||
          Txt_PasswordR.Text == "" ||
          Txt_EmailR.Text == "" ||
          Txt_IDCardR.Text == "" ||
          Txt_NameR.Text == "")
            {
                Txt_Account.Text = "請輸入帳號";
                Txt_Password.PasswordChar = default;
                Txt_Password.Text = "請輸入密碼";
                Txt_PhoneR.Text = "請輸入電話（電話即為帳號）";
                Txt_PasswordR.Text = "請輸入密碼";
                Txt_EmailR.Text = "請輸入Email";
                Txt_IDCardR.Text = "請輸入身份證字號";
                Txt_NameR.Text = "請輸入姓名";
                Txt_Account.ForeColor = Color.Gray;
                Txt_Password.ForeColor = Color.Gray;
                Txt_PhoneR.ForeColor = Color.Gray;
                Txt_PasswordR.ForeColor = Color.Gray;
                Txt_EmailR.ForeColor = Color.Gray;
                Txt_IDCardR.ForeColor = Color.Gray;
                Txt_NameR.ForeColor = Color.Gray;
                textboxHasText = false;
            }
            else
            {
                textboxHasText = true;
            }
        }

        private void Txt_Account_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_Account.Text = "";

            Txt_Account.ForeColor = Color.Black;
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_Password.Text = "";
            Txt_Password.PasswordChar = '*';
            Txt_Password.ForeColor = Color.Black;
        }

        private void Txt_PhoneR_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_PhoneR.Text = "";

            Txt_PhoneR.ForeColor = Color.Black;
        }

        private void Txt_PasswordR_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_PasswordR.Text = "";

            Txt_PasswordR.ForeColor = Color.Black;
        }

        private void Txt_IDCardR_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_IDCardR.Text = "";

            Txt_IDCardR.ForeColor = Color.Black;
        }

        private void Txt_NameR_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_NameR.Text = "";

            Txt_NameR.ForeColor = Color.Black;
        }

        private void Txt_EmailR_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Txt_EmailR.Text = "";

            Txt_EmailR.ForeColor = Color.Black;
        }



        private void Btn_Demo2_Click(object sender, EventArgs e)
        {
            Txt_PhoneR.Text = "0912345678";
            Txt_EmailR.Text = "1234@gmail.com";
            Txt_PasswordR.Text = "12345678";
            Txt_NameR.Text = "林大明";
            Txt_IDCardR.Text = "A123456789";
            Time_BirthDate.Value = new DateTime(2001, 10, 20);
            Combo_Gender.SelectedIndex = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
