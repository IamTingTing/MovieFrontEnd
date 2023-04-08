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
    public partial class Order_MemberOrderDetails : Form
    {
        public Order_MemberOrderDetails()
        {
            InitializeComponent();

            //測試用而已，不用下面兩行
            ShowOrders();
            ShowOrderDetails();
        }

        int OrderID;
        public Order_MemberOrderDetails(int ID)
        {
            InitializeComponent();
            OrderID = ID;
            ShowOrders();
            ShowOrderDetails();
            
        }

        MovieEntities movieEntities = new MovieEntities();
        private void ShowOrders()
        {
            var query = movieEntities.Orders.AsEnumerable().
                Where(o => o.Order_ID == OrderID);
            foreach(var item in query)
            {
                lab_ticketName.Text = "電影："+item.Session.Movie.MovieNameCht;
                lab_movieDuration.Text = "片長："+item.Session.Movie.MovieShowLength.ToString()+"分鐘";
            }
        }

        
        private void ShowOrderDetails()
        {
            var query = movieEntities.OrderDetails.AsEnumerable().
                Where(o => o.Order_ID == OrderID);

            flowLayoutPanel_showOrderDetails.Controls.Clear();
            
            foreach(var item in query)
            {
                UserControl_MemberOrderDetails TicketDetails = new UserControl_MemberOrderDetails();
                TicketDetails.Margin = new Padding(10);
                TicketDetails.Size = new Size(100,50);
                TicketDetails.ticketInfo = item.TicketClass.TicketClass1;
                TicketDetails.seatInfo = "第" + item.Seat.SeatRow + "排" + "第" + item.Seat.SeatNum + "個";
                flowLayoutPanel_showOrderDetails.Controls.Add(TicketDetails);
            }
        }

        private void Order_MemberOrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
