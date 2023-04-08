using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frm販賣部;
using Movie_Member;
using MovieFrontEnd;
using MovieOrderSystem;
using prjMovieCmt;
using static Frm販賣部.Product_frm小賣部;
using static MovieOrderSystem.Order_Booking;

namespace prjMovie2023
{
    public partial class Movie_MovieFron_01 : Form
    {
        public Movie_MovieFron_01()
        {
            InitializeComponent();
        }


        MovieEntities movieEntities = new MovieEntities();

        private void frm_Movie_MovieFron_01_Load(object sender, EventArgs e)
        {
            var q = from p in movieEntities.Movies
                    select new {
                        MovieId = p.Movie_ID,
                        MoviePoster = p.MoviePoster
                    };

            this.fLP_MovieFron_01_MovieList.Controls.Clear();
            foreach (var image in q)
            {
                if (image.MoviePoster != null)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Click += Pic_Click;      //加入圖片點擊事件

                    pic.Width = 120;             //設定長寬
                    pic.Height = 160;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Name = image.MovieId.ToString();
                    using (MemoryStream stream = new MemoryStream(image.MoviePoster))
                    {
                        pic.Image = System.Drawing.Image.FromStream(stream);
                    }
                    this.fLP_MovieFron_01_MovieList.Controls.Add(pic);
                }
            }
        }

        public int MovieIdShare;
        private void Pic_Click(object sender, EventArgs e)
        {
            MovieIdShare = Convert.ToInt32(((PictureBox)sender).Name);
            Movie_MovieFron_02 f = new Movie_MovieFron_02(MovieIdShare);
            f.Show();
        }

        Member_LogIn_Register login;
        private void btn_MovieFron_01_Login_Click(object sender, EventArgs e)
        {
            //連結Login表單
            login = new Member_LogIn_Register();
            //login.Show();
            //login.ShowDialog();
            if (login.ShowDialog() == DialogResult.OK)
                Login_frmLogIn();
            //login.frmLogIn += Login_frmLogIn;
        }

        private void Login_frmLogIn()
        {
            txt_account = login.Member;
            splitContainer2.Panel1Collapsed = false;

            btn_Login.Visible = false;
            lab_SayHello.Visible = true;
            btn_LogOut.Visible = true;

            var query = movieEntities.Members.Where(m => m.Phone == txt_account).FirstOrDefault();
            lab_SayHello.Text = $"哈囉" + query.Name;
        }

        string txt_account;
        private void toolStripButton_MemberInfo_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Member_Main f = new Member_Main(txt_account);
            f.callbooking += this.BookingOrders_Mdi;
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }
        private void BookingOrders_Mdi(int id)
        {
            var query_member = movieEntities.Members.AsEnumerable().
               Where(m => m.Phone == txt_account).FirstOrDefault();
            memberID = query_member.MemberID;
            Order_Booking booking = new Order_Booking(memberID, id);
            this.splitContainer2.Panel2.Controls.Clear();
            booking.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(booking);
            booking.Show();
        }

        int memberID;
        private void toolStripButton_SelectOrders_Click(object sender, EventArgs e)
        {
            var query_member = movieEntities.Members.AsEnumerable().
                Where(m => m.Phone == txt_account).FirstOrDefault();
            memberID = query_member.MemberID;

            splitContainer2.Panel2.Controls.Clear();
            Order_MemberOrder f = new Order_MemberOrder(memberID);
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        Order_Booking f;

        private void toolStripButton_InsertOrders_Click(object sender, EventArgs e)
        {
            var query_member = movieEntities.Members.AsEnumerable().
                Where(m => m.Phone == txt_account).FirstOrDefault();
            memberID = query_member.MemberID;

            splitContainer2.Panel2.Controls.Clear();
            f = new Order_Booking(memberID);
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();

            f.showProductForm += F_showProductForm;
            f.showProductFormWithCoupon += F_showProductFormWithCoupon;
        }

        private void F_showProductFormWithCoupon(string Coupon)
        {
            Product_frm小賣部 f = new Product_frm小賣部(memberID,Coupon);
            f.TopLevel = false;

            splitContainer2.Panel2.Controls.Add(f);
            f.Show();

            f.showOrderForm += F_showOrderForm;

        }

        private void F_showProductForm()
        {
            Product_frm小賣部 f = new Product_frm小賣部(memberID);
            f.TopLevel = false;

            splitContainer2.Panel2.Controls.Add(f);
            f.Show();

            f.showOrderForm += F_showOrderForm;
        }

        private void F_showOrderForm(int memberID, int Price)
        {
            f.TotalProductPrice = Price;
            f.Show();
        }

        private void toolStripButton_InsertProduct_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Product_frm小賣部 f = new Product_frm小賣部();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void toolStripButton_Comment_Click(object sender, EventArgs e)
        {
            var query_member = movieEntities.Members.AsEnumerable().
                           Where(m => m.Phone == txt_account).FirstOrDefault();
            memberID = query_member.MemberID;
            splitContainer2.Panel2.Controls.Clear();
            Comment_FrmMovieCmt f = new Comment_FrmMovieCmt(memberID);
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void toolStripButton_Complaint_Click(object sender, EventArgs e)
        {
            var query_member = movieEntities.Members.AsEnumerable().
              Where(m => m.Phone == txt_account).FirstOrDefault();
            memberID = query_member.MemberID;
            splitContainer2.Panel2.Controls.Clear();
            Comment_FrmComplaint f = new Comment_FrmComplaint(memberID);
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("確認要登出嗎?");
            if(result==DialogResult.OK)
            {
                btn_LogOut.Visible = false;
                lab_SayHello.Text = "";
                btn_Login.Visible = true;
                splitContainer2.Panel2.Controls.Clear();
                splitContainer2.Panel1Collapsed = true;
                txt_account = "";
            }

            //登出後show圖片
            var q = from p in movieEntities.Movies
                    select new
                    {
                        MovieId = p.Movie_ID,
                        MoviePoster = p.MoviePoster
                    };

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Margin = new Padding(10);
            foreach (var image in q)
            {
                if (image.MoviePoster != null)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Click += Pic_Click;      //加入圖片點擊事件

                    pic.Width = 120;             //設定長寬
                    pic.Height = 160;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Name = image.MovieId.ToString();
                    using (MemoryStream stream = new MemoryStream(image.MoviePoster))
                    {
                        pic.Image = System.Drawing.Image.FromStream(stream);
                    }
                    flowLayoutPanel.Controls.Add(pic);
                }
            }
            this.splitContainer2.Panel2.Controls.Add(flowLayoutPanel);



        }
    }
}
