using MovieFrontEnd;
using MovieOrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrderSystem
{
    public partial class Order_MemberOrder : Form
    {
        public Order_MemberOrder()
        {
            InitializeComponent();
        }

        int loginMemberID;
        public Order_MemberOrder(int memberID)
        {
            InitializeComponent();
            loginMemberID = memberID;
            LoadMemberOrder();
        }

        MovieEntities movieEntities = new MovieEntities();
        private void LoadMemberOrder()
        {
            //抓出特定會員訂單中的電影名字、影廳資訊、時段
            var query_order = movieEntities.Orders.AsEnumerable().
                Where(o => o.Member_ID == loginMemberID).
                  Select(o => new
                  {
                      o.Session.Movie.MovieNameCht,
                      o.Session.Theater.Theater1,
                      o.Session.PlayDate,
                      o.Session.PlayTimeDetail.PlayTime,
                      o.Order_ID,
                      o.Session.Movie.MoviePoster
                  }) ;
            //GridView_demo.DataSource = query_order.ToList();

            //訂電影票初始位置
            int positionX = 20;
            int positionY = 25;

            //顯示訂過的電影票
            foreach(var item in query_order)
            {
                UserControl_MemberOrder movieTicket = new UserControl_MemberOrder();
                movieTicket.movieName = item.MovieNameCht;
                movieTicket.theaterInfo = item.Theater1;
                movieTicket.sessionInfo = item.PlayDate.ToString("yyyy/MM/dd")+"  "+ item.PlayTime;
                movieTicket.Size = new Size(250, 95);
                movieTicket.Location = new Point(positionX, positionY);
                positionY += 100;
                movieTicket.OrderIDInfo = item.Order_ID;
                movieTicket.MoviePoster = item.MoviePoster;

                movieTicket.Click += MovieTicket_Click;

                splitContainer1.Panel1.Controls.Add(movieTicket);
            }
        }

        private void MovieTicket_Click(object sender, EventArgs e)
        {
            Order_MemberOrderDetails f = new Order_MemberOrderDetails(
                ((UserControl_MemberOrder)sender).OrderIDInfo);

            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Panel2.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2Collapsed = false;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }
    }
}
