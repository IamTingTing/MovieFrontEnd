using Movie_Member;
using MovieFrontEnd;
using MovieOrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Movie_Member
{
    public partial class Member_Main : Form
    {
        public Member_Main()
        {
            InitializeComponent();
            
        }
        public delegate void DCallBack(int movieID);
        public event DCallBack callbooking;
        public Member_Main(string account)
        {
            InitializeComponent();
            Txt_Phone.Text = account;
        }

        MovieEntities movieEntities = new MovieEntities();
        private void Member_Main_Load(object sender, EventArgs e)
        {
            //會員資料頁面
            var q = (from m in this.movieEntities.Members
                     where m.Phone == Txt_Phone.Text
                     select m).FirstOrDefault();
            Txt_Password.Text = q.Password;
            Txt_MemberID.Text = q.MemberID.ToString();
            Txt_Email.Text = q.Email;
            Txt_IDCard.Text = q.IDCardNumber;
            Txt_Name.Text = q.Name;
            Txt_NickName.Text = q.Nickname;
            Time_BirthDate.Value = q.BirthDate.Value;
            Combo_Gender.SelectedIndex = q.GenderID - 1;
            Lab_Membership.Text = $"{q.Membership.Membership_Name}";
            Lab_DispalyName.Text = q.Name;
            if (q.MembershipID == 3)
            {
                Lab_Upgrade.Text = $"12/31前消費滿2000元即可晉升{q.Membership.Membership_Name}\n" +
                    $"可享有購票85折優惠";
            }
            else if (q.MembershipID == 2)
            {
                Lab_Upgrade.Text = $"12/31前消費滿3000元即可晉升{q.Membership.Membership_Name}\n" +
                      $"可享有購票8折優惠";
            }
            else if (q.MembershipID == 1)
            {
                Lab_Upgrade.Text = "";
            }
            Btn_Update.Visible = false;
            groupBox2.Visible = false;

            //訂單資料頁面--給婷婷

            //優惠券-未使用
            var qc = from c in this.movieEntities.CouponLists
                     where c.Member.Phone == Txt_Phone.Text && c.IsUsed == 0 && c.CouponType.Coupon_DueDate>DateTime.Now
                     select c;
            foreach(var item in qc)
            {
                UserControl_Coupon coupon = new UserControl_Coupon();
                coupon.Coupon_Name = item.CouponType.Coupon_Type_Name; 
                coupon.Coupon_Discount= $"{item.CouponType.Coupon_Discount.ToString()}折";
                coupon.Coupon_DueDate = item.CouponType.Coupon_DueDate.ToString("D");
                coupon.Padding=new Padding(10, 10, 10, 10);
                this.Coupon_flowLayoutPanel.Controls.Add(coupon);
                coupon.Btn_Coupon.Click += Btn_Coupon_Click;
            }
            //優惠券-已使用
            var qused =from c in this.movieEntities.CouponLists
                          where c.Member.Phone == Txt_Phone.Text && c.IsUsed == 1 
                          select c;
            foreach (var item in qused)
            {
                UserControl_Coupon coupon1 = new UserControl_Coupon();
                coupon1.Coupon_Name = item.CouponType.Coupon_Type_Name;
                coupon1.Coupon_Discount = $"{item.CouponType.Coupon_Discount.ToString()}折";
                coupon1.Coupon_DueDate = item.CouponType.Coupon_DueDate.ToString("D");
                coupon1.Padding = new Padding(10, 10, 10, 10);
                this.Used_flowLayoutPanel.Controls.Add(coupon1);
                coupon1.Coupon_Used = false;
                
            }
            //優惠券-已過期
            var qunused = from c in this.movieEntities.CouponLists
                          where c.Member.Phone == Txt_Phone.Text && c.IsUsed == 0 && c.CouponType.Coupon_DueDate < DateTime.Now
                          select c;
            foreach (var item in qunused)
            {
                UserControl_Coupon coupon2 = new UserControl_Coupon();
                coupon2.Coupon_Name = item.CouponType.Coupon_Type_Name;
                coupon2.Coupon_Discount = $"{item.CouponType.Coupon_Discount.ToString()}折";
                coupon2.Coupon_DueDate = item.CouponType.Coupon_DueDate.ToString("D");
                coupon2.Padding = new Padding(10, 10, 10, 10);
                this.Expire_flowLayoutPanel.Controls.Add(coupon2);
                coupon2.Coupon_Used = false;
            }

            //片單
          
            load_Favorite();
            var qmovie = from m in this.movieEntities.Movies
                         where m.MovieScheduleStart < DateTime.Now && m.MovieScheduleEnd > DateTime.Now
                         select m;

            this.comboBox1.DataSource = qmovie.ToList();
            this.comboBox1.DisplayMember = "MovieNameCht";


        }

        UserControl_Favorite favorite;
        public void load_Favorite()
        {
            var qfavor = from f in this.movieEntities.MemberActions
                         where f.Member.Phone == Txt_Phone.Text && f.ActionTypeID == 1
                         select f;
            foreach (var item in qfavor)
            {
                favorite = new UserControl_Favorite();
                favorite.Favor_MovieName = item.Movie.MovieNameCht;

                byte[] bytes = (byte[])item.Movie.MoviePoster;
                MemoryStream ms = new MemoryStream(bytes);
                favorite.Favor_Poster = System.Drawing.Image.FromStream(ms);
                Favorite_flowLayoutPanel.Controls.Add(favorite);
                favorite.Btn_Order.Name= item.Movie.Movie_ID.ToString();
                favorite.Btn_Order.Click += Btn_Order_Click;

            }
        }
        private void Btn_Coupon_Click(object sender, EventArgs e)
        {
            //callbooking(favorite.Favor_MovieID);

        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            callbooking(int.Parse(((Button)sender).Name));
            
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            var q = (from m in this.movieEntities.Members
                     where m.Phone == Txt_Phone.Text
                     select m).FirstOrDefault();
            q.Password = Txt_Password.Text;
            q.Name = Txt_Name.Text;
            q.Email = Txt_Email.Text;
            q.IDCardNumber = Txt_IDCard.Text;
            q.BirthDate = Time_BirthDate.Value;
            q.GenderID = Combo_Gender.SelectedIndex + 1;
            q.Nickname = Txt_NickName.Text;

            this.movieEntities.SaveChanges();
            MessageBox.Show(" 修改成功！");
        }



        private void OrderQuery_Click(object sender, EventArgs e)
        {

        }



        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl2.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl1.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl2.Font, Brushes.Black, x, y);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Btn_Update.Visible = true;
            groupBox2.Visible = true;
        }

        private void Btn_Favor_Insert_Click(object sender, EventArgs e)
        {
            MemberAction memberAction = new MemberAction
            {
                MemberID = int.Parse(Txt_MemberID.Text),
                MovieID = comboBox1.SelectedIndex + 1,
                ActionTypeID = 1,

            };
            this.movieEntities.MemberActions.Add(memberAction);
            this.movieEntities.SaveChanges();

            MessageBox.Show("新增成功");
            load_Favorite();
        }
    }
}
