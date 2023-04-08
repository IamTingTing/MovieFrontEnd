using MovieOrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Data.Entity.Core.Mapping;
using MovieFrontEnd;
using Frm販賣部;

namespace MovieOrderSystem
{
    public partial class Order_Booking : Form
    {
        public Order_Booking()
        {
            InitializeComponent();
            //一進來畫面就顯示電影
            timer_showMoviePoster.Start();
            
            var query = movieEntities.Movies;
            foreach (var item in query)
            {
                comboBox_SelectMovie.Items.Add(item.MovieNameCht);
            } 
        }

        int memberID;
        public Order_Booking(int memID)
        {
            InitializeComponent();
            //一進來畫面就顯示電影
            timer_showMoviePoster.Start();
            memberID = memID;

            var query = movieEntities.Movies.Where(m => m.MovieScheduleEnd >= DateTime.Now);
            foreach (var item in query)
            {
                comboBox_SelectMovie.Items.Add(item.MovieNameCht);
            }          
        }

        bool couponUsed = false;
        string coupon;
        public Order_Booking(int memID,string couponID)
        {
            InitializeComponent();
            //一進來畫面就顯示電影
            timer_showMoviePoster.Start();
            memberID = memID;

            var query = movieEntities.Movies.Where(m=>m.MovieScheduleEnd>=DateTime.Now);
            foreach (var item in query)
            {
                comboBox_SelectMovie.Items.Add(item.MovieNameCht);
            }
            couponUsed = true;
            coupon = couponID;
        }

        public Order_Booking(int memID,int movieID)
        {
            InitializeComponent();
            //一進來畫面就顯示電影
            timer_showMoviePoster.Start();
            memberID = memID;
            
            var query = movieEntities.Movies.Where(m=>m.Movie_ID==movieID);
            foreach (var item in query)
            {
                comboBox_SelectMovie.Text=item.MovieNameCht;
                ShowSelectedMovieInfo(item.MovieNameCht);
            }
            var query1= movieEntities.Movies;
            foreach (var item in query1)
            {
                comboBox_SelectMovie.Items.Add(item.MovieNameCht);
            }
        }

        MovieEntities movieEntities = new MovieEntities();
        public int TotalProductPrice=0;

        private void comboBox_SelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieName = comboBox_SelectMovie.Text;
            ShowSelectedMovieInfo(movieName);
        }

        private void datePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            //選完想看的日期後顯示場次資訊
            var query_session = movieEntities.Sessions.
                Where(s => s.Movie.MovieNameCht == comboBox_SelectMovie.Text);

            var query_advancedSession=query_session.
                Where(s=>s.PlayDate==datePicker_Date.Value);

            comboBox_SelectSession.Items.Clear();
            LoadComboBox_Session();
        }

        List<int> list_StoreSelectedSessionID = new List<int>();
        void LoadComboBox_Session()
        {
            //用額外做的class呈現session資訊
            var query_session=movieEntities.Sessions.
                Where(s => s.Movie.MovieNameCht == comboBox_SelectMovie.Text);

            var query_advancedSession = query_session.
                Where(s => s.PlayDate == datePicker_Date.Value);

            SelectedSession selectedSession = new SelectedSession();
            list_StoreSelectedSessionID.Clear();
            comboBox_SelectSession.Items.Clear();

            foreach(var item in query_advancedSession)
            {
                selectedSession.SelectedSessionID = item.Session_ID;
                selectedSession.SelectedPlayTime = item.PlayTimeDetail.PlayTime;
                selectedSession.TheaterName = item.Theater.Theater1;
                
                comboBox_SelectSession.Items.Add(selectedSession.ShowString());
                list_StoreSelectedSessionID.Add(selectedSession.SelectedSessionID);
            }
        }

        int CheckSelectedSession()
        {
            int sessionID = list_StoreSelectedSessionID[comboBox_SelectSession.SelectedIndex];
            return sessionID;
        }

        int sessionID;
        private void comboBox_SelectSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            //找到選擇的sessionID
            sessionID = CheckSelectedSession();
            var query = movieEntities.Sessions.Where(s=>s.Session_ID==sessionID).FirstOrDefault().Orders;

            //確認剩餘座位
            int count_notSeat= movieEntities.Sessions.Where(s => s.Session_ID == sessionID).
                FirstOrDefault().Theater.Seats.Where(s => s.SeatStatus_ID == 2).Count();
            int count=0;
            foreach(var item in query)
            {
                count+=item.OrderDetails.Count();
            }
            txt_SeatLeft.Text = (400-count-count_notSeat).ToString();
        }

        int studentNumber;
        int normalNumber;
        int soldierNumber;

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {

            if (comboBox_SelectSession.Text=="")
            {
                MessageBox.Show("請選擇場次");
                return;
            }    
            //查詢選到的場次的電影名稱、時段、影廳
            string movieName = movieEntities.Sessions.Where(s=>
            s.Session_ID==sessionID).FirstOrDefault().Movie.MovieNameCht;
            string playtime = movieEntities.Sessions.Where(s => 
            s.Session_ID == sessionID).FirstOrDefault().PlayTimeDetail.PlayTime.ToString();
            string theaterName = movieEntities.Sessions.Where(s => 
            s.Session_ID == sessionID).FirstOrDefault().Theater.Theater1;

            var query_member=movieEntities.Members.Where(m => m.MemberID == memberID);
            string name=null;
            foreach(var item in query_member)
            {
                name = item.Name;
            }

            //查詢想要的時間
            string date = datePicker_Date.Value.ToString("yyyy/MM/dd");

            //查詢人數 
            bool verify_studentNumber= int.TryParse
                (comboBox_ticketNO_student.Text,out studentNumber);
            bool verify_normalNumber= int.TryParse
                (comboBox_ticketNO_normal.Text,out normalNumber);
            bool verify_soldierNumber= int.TryParse
                (comboBox_ticketNO_soldier.Text,out soldierNumber);

            if (verify_normalNumber == false)
                normalNumber = 0;
            if (verify_studentNumber == false)
                studentNumber = 0;
            if (verify_soldierNumber == false)
                soldierNumber = 0;


            DialogResult result =MessageBox.Show($"嗨{name}\n您的訂購資訊為" +
                $"：\n{movieName}\n{theaterName}\n{date} {playtime}\n 一般票：{normalNumber}張，" +
                $"學生票：{studentNumber}張，軍警票：{soldierNumber}張\n"
                ,"訂購資訊",MessageBoxButtons.OKCancel);

            lab_SelectedSeat.Text = "尚未選擇座位";

            if (result == DialogResult.OK)
            {
                DialogResult result1 = MessageBox.Show("是否要搭配套餐?",
                    "搭配套餐", MessageBoxButtons.OKCancel);
                if(result1==DialogResult.OK)
                {
                    if(couponUsed==false)
                    {
                        tabControl_booking.SelectedIndex = 1;
                        this.Hide();
                        showProductForm();
                    }
                    else
                    {
                        tabControl_booking.SelectedIndex = 1;
                        this.Hide();
                        showProductFormWithCoupon(coupon);
                    }
                }
                else
                {
                    tabControl_booking.SelectedIndex = 1;
                }
            }
        }

        public delegate void ShowProductForm();
        public event ShowProductForm showProductForm;

        public delegate void ShowProductFromWithCoupon(string Coupon);
        public event ShowProductFromWithCoupon showProductFormWithCoupon;

        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        List<CheckedSeatPosition> list_selectedSeat = new List<CheckedSeatPosition>();
        int totalTicketCount = 0;
        private void btn_chooseSeat_Click(object sender, EventArgs e)
        {
            //查詢被選走的座位
            int theaterID = movieEntities.Sessions.Where(s=>s.Session_ID==sessionID)
                .FirstOrDefault().Theater_ID;

            var query_orderdetails = movieEntities.OrderDetails.
                Where(od => od.Order.Session.Session_ID == sessionID);

            foreach (var item in query_orderdetails)
            {
                list1.Add(item.Seat_ID - (theaterID - 1) * 400);
            }

            //查詢狀態為2的座位--非座位
            var query_SeatStatus2 = movieEntities.Seats.Where(s => s.Theater_ID == theaterID && s.SeatStatus_ID == 2);
            foreach (var item in query_SeatStatus2)
            {
                list2.Add(item.Seat_ID - (theaterID - 1) * 400);
            }

            //查詢狀態為3的座位
            var query_SeatStatus3 = movieEntities.Seats.Where(s => s.Theater_ID == theaterID && s.SeatStatus_ID == 3);
            foreach (var item in query_SeatStatus3)
            {
                list3.Add(item.Seat_ID - (theaterID - 1) * 400);
            }

            //查詢會員想要訂的票數
            totalTicketCount = studentNumber+normalNumber+soldierNumber;

            Order_Seat f = new Order_Seat(list1,list2,list3,totalTicketCount);
            DialogResult result=f.ShowDialog();
            if(result==DialogResult.OK)
            {
                list_selectedSeat = f.list_checked;
                lab_SelectedSeat.Text = "選擇的座位有\n";
            }
            foreach (var item in list_selectedSeat)
                lab_SelectedSeat.Text += item+"\n";

            //將回傳的ID值變正確
            foreach(var item in list_selectedSeat)
            {
                item.SeatID = item.SeatID + (theaterID - 1) * 400;
            }
        }

        private void btn_ConfirmOrderDetails_Click(object sender, EventArgs e)
        {
            //查詢選到的場次的電影名稱、時段、影廳
            string movieName = movieEntities.Sessions.Where(s =>
                s.Session_ID == sessionID).FirstOrDefault().Movie.MovieNameCht;
            string playtime = movieEntities.Sessions.Where(s =>
                s.Session_ID == sessionID).FirstOrDefault().
                PlayTimeDetail.PlayTime.ToString();
            string theaterName = movieEntities.Sessions.Where(s =>
                s.Session_ID == sessionID).FirstOrDefault().Theater.Theater1;

            //查詢會員名字
            var query_member = movieEntities.Members.Where(m => m.MemberID == memberID);
            string name = null;
            string membership = null;
            foreach (var item in query_member)
            {
                name = item.Name;
                membership = item.Membership.Membership_Name;
            }

            //查詢想要的時間
            string date = datePicker_Date.Value.ToString("yyyy/MM/dd");

            lab_OrderDetails_ShowMemberName.Text = name;
            lab_OrderDetails_ShowMembership.Text = membership;
            lab_OrderDetails_ShowMovie.Text = movieName;
            lab_OrderDetails_ShowTheater.Text = theaterName;
            lab_OrderDetails_ShowSession.Text = date + " " + playtime;
            LoadComoBox();
            lab_OrderDetails_ShowTicketClassCount.Text = "共" + totalTicketCount.ToString() + "張";
            lab_OrderDetails_ShowSeat.Text = lab_SelectedSeat.Text;

            LoadOrderDetailsAndTotalPrice();
            tabControl_booking.SelectedIndex = 2;
        }

        double TotalPrice = 0;

        private void LoadOrderDetailsAndTotalPrice()
        {
            //找尋會員等級
            decimal pricerate_membership = movieEntities.Members.AsEnumerable().
                Where(m => m.MemberID == memberID).
                FirstOrDefault().Membership.PriceRate.Value;

            //確認是否為早場(12點之前)
            DateTime t_choose = DateTime.Parse(movieEntities.Sessions.AsEnumerable().
                Where(s=>s.Session_ID==sessionID).FirstOrDefault().
                PlayTimeDetail.PlayTime.ToString());
            DateTime t_standard = DateTime.Parse("11:30:00");
            int CompareResult = DateTime.Compare(t_choose, t_standard);
            decimal pricerate_date;
            if (CompareResult == -1)
            {
                pricerate_date = movieEntities.TicketClasses.Where(t => t.TicketClass1 == "早場").FirstOrDefault().PriceRate;
            }
            else
                pricerate_date = 1;

            //算不同票種間的優惠
            decimal pricerate_ticketclass_normal = movieEntities.TicketClasses.AsEnumerable().
                Where(t => t.TicketClass1 == "一般").FirstOrDefault().PriceRate;
            decimal pricerate_ticketclass_student = movieEntities.TicketClasses.AsEnumerable().
                Where(t => t.TicketClass1 == "學生").FirstOrDefault().PriceRate;
            decimal pricerate_ticketclass_soldier = movieEntities.TicketClasses.AsEnumerable().
                Where(t => t.TicketClass1 == "軍警").FirstOrDefault().PriceRate;

           
            decimal NormalPrice = 0; ;
            if (normalNumber > 0)
            {
                decimal[] comparePriceRate_normal = new decimal[3] { pricerate_membership, pricerate_date, pricerate_ticketclass_normal };
                decimal minPriceRate_normal = comparePriceRate_normal.Min();
                NormalPrice = normalNumber * minPriceRate_normal * 350;
            }

            decimal StudentPrice = 0;
            if (studentNumber > 0)
            {
                decimal[] comparePriceRate_student = new decimal[3] { pricerate_membership, pricerate_date, pricerate_ticketclass_student };
                decimal minPriceRate_student = comparePriceRate_student.Min();
                StudentPrice = studentNumber * minPriceRate_student * 350;
            }

            decimal SoldierPrice = 0;
            if (soldierNumber > 0)
            {
                decimal[] comparePriceRate_soldier = new decimal[3] { pricerate_membership, pricerate_date, pricerate_ticketclass_soldier };
                decimal minPriceRate_soldier = comparePriceRate_soldier.Min();
                SoldierPrice = soldierNumber * minPriceRate_soldier * 350;
            }

            //確認廳院
            int theaterClassID = movieEntities.Sessions.AsEnumerable().
                Where(s => s.Session_ID ==sessionID).FirstOrDefault().
                Theater.TheaterClass_ID;
            decimal pricerate_theaterClass = 0;
            if (theaterClassID == 1)
                pricerate_theaterClass = movieEntities.TheaterClasses.
                    Where(t => t.TheaterClass_ID == 1).
                    FirstOrDefault().PriceRate;
            else
                pricerate_theaterClass = movieEntities.TheaterClasses.
                    Where(t => t.TheaterClass_ID == 2).
                    FirstOrDefault().PriceRate;

            TotalPrice = Convert.ToInt32((NormalPrice + StudentPrice + SoldierPrice) * pricerate_theaterClass);
            lab_OrderDetails_ShowTicketMoney.Text = TotalPrice.ToString()+"元";

            lab_OrderDetails_ShowProductMoney.Text = TotalProductPrice.ToString() + "元";

            lab_ShowTotalPrice.Text = (TotalPrice + TotalProductPrice).ToString() + "元";
        }

        void LoadComoBox()
        {
            comboBox_OrderDetails_ShowPaymentType.Items.Clear();
            var query=movieEntities.PayTypes;
            foreach(var item in query)
            {
                string str=item.PayType1.Trim();
                comboBox_OrderDetails_ShowPaymentType.Items.Add(str);
            }
        }

        private void linkLabel_CreditCardInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = movieEntities.CreditCardTypes;
            string str=null;
            foreach(var item in query)
            {
                str += $"{item.CreditCardType1.Trim()}:票價*{item.PriceRate}\n";
            }
            MessageBox.Show(str);
        }

        private void comboBox_OrderDetails_ShowPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            double TotalPrice_After;
            //確認付款方式
            if (comboBox_OrderDetails_ShowPaymentType.Text == "信用卡")
            {
                TotalPrice_After = Math.Round(TotalPrice * 0.9);
                lab_OrderDetails_ShowTicketMoney.Text = TotalPrice_After.ToString() + "元";
                lab_ShowTotalPrice.Text = (TotalPrice_After + TotalProductPrice).ToString() + "元";
            }
            else
            {
                lab_OrderDetails_ShowTicketMoney.Text = TotalPrice.ToString() + "元";
                lab_ShowTotalPrice.Text = (TotalPrice + TotalProductPrice).ToString() + "元";
            }

            
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //string s = comboBox_OrderDetails_ShowPaymentType.Text;
                    //var q = movieEntities.PayTypes.AsEnumerable().Where(p => p.PayType1 == s);
                    ////var q = movieEntities.PayTypes.AsEnumerable();
                    //dataGridView1.DataSource = q.ToList();

                    //insert Orders資料
                    //int payTypeID = movieEntities.PayTypes.AsEnumerable().Where
                    //    (p => p.PayType1 == comboBox_OrderDetails_ShowPaymentType.Text).
                    //    FirstOrDefault().PayType_ID;

                    int payTypeID = movieEntities.PayTypes.AsEnumerable().Where
                        (p => p.PayType_ID == (comboBox_OrderDetails_ShowPaymentType.
                        SelectedIndex + 1)).FirstOrDefault().PayType_ID;
                    Order order = new Order
                    {
                        Session_ID = sessionID,
                        Member_ID = memberID,
                        PayType_ID = payTypeID,
                        OrderDate = DateTime.Now
                    };
                    movieEntities.Orders.Add(order);
                    movieEntities.SaveChanges();

                    //insert OrderStatus資料
                    int orderID = movieEntities.Orders.OrderByDescending
                        (o => o.Order_ID).FirstOrDefault().Order_ID;
                    OrderStatu orderStatu = new OrderStatu
                    {
                        OrderStatus = "已訂票",
                        ChangedTime = DateTime.Now
                    };
                    movieEntities.OrderStatus.Add(orderStatu);
                    movieEntities.SaveChanges();

                    //算總票數對應的TicketClassID
                    List<int> list_TicketsCount = new List<int>();
                    if (normalNumber > 0)
                    {
                        for (int i = 0; i < normalNumber; i++)
                            list_TicketsCount.Add(movieEntities.TicketClasses.
                                Where(t => t.TicketClass1 == "一般").FirstOrDefault().
                                TicketClass_ID);
                    }
                    if (studentNumber > 0)
                    {
                        for (int i = 0; i < studentNumber; i++)
                            list_TicketsCount.Add(movieEntities.TicketClasses.
                                Where(t => t.TicketClass1 == "學生").FirstOrDefault().
                                TicketClass_ID);
                    }
                    if (soldierNumber > 0)
                    {
                        for (int i = 0; i < soldierNumber; i++)
                            list_TicketsCount.Add(movieEntities.TicketClasses.
                                Where(t => t.TicketClass1 == "軍警").FirstOrDefault().
                                TicketClass_ID);
                    }


                    //insert OrderDetails資料
                    for (int i = 0; i < list_selectedSeat.Count; i++)
                    {
                        OrderDetail orderDetail = new OrderDetail
                        {
                            Order_ID = orderID,
                            Seat_ID = list_selectedSeat[i].SeatID,
                            TicketClass_ID = list_TicketsCount[i]
                        };
                        movieEntities.OrderDetails.Add(orderDetail);
                    }
                    movieEntities.SaveChanges();

                    //insert OrderStatusLog資料
                    int orderStatusID = movieEntities.OrderStatus.
                        OrderByDescending(o => o.OrderStatus_ID).FirstOrDefault().
                        OrderStatus_ID;
                    OrderStatusLog orderStatusLog = new OrderStatusLog()
                    {
                        OrderStatusID = orderStatusID,
                        OrderID = orderID
                    };
                    movieEntities.OrderStatusLogs.Add(orderStatusLog);
                    movieEntities.SaveChanges();


                    MessageBox.Show("訂購成功");
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BackToConfirmOrder_Click(object sender, EventArgs e)
        {
            tabControl_booking.SelectedIndex = 0;
        }



        private void btn_chooseFood_Click(object sender, EventArgs e)
        {
            Product_frm小賣部 f = new Product_frm小賣部(memberID);
            this.Close();
            
            f.ShowDialog();
            
        }

        int index = 0;
        private void timer_showMoviePoster_Tick(object sender, EventArgs e)
        {
            var query_movie = movieEntities.Movies.OrderBy(m => m.Movie_ID).
                Where(m => m.MovieScheduleEnd >= DateTime.Now).
               Skip(index).Take(1);
            int movieCount = movieEntities.Movies.Count();
            foreach (var item in query_movie)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(item.MoviePoster);
                pictureBox_MovieRecommend.Image = System.Drawing.Image.FromStream(memoryStream);
                pictureBox_MovieRecommend.Name = item.MovieNameCht;
            }
          
            index++;
            if (index == movieCount)
            {
                index = 0;
            }
        }

        private void pictureBox_MovieRecommend_Click(object sender, EventArgs e)
        {
            ShowSelectedMovieInfo(((PictureBox)sender).Name);
        }

        void ShowSelectedMovieInfo(string movieName)
        {
            //顯示電影細節
            var query = movieEntities.Movies.Where
                (x => x.MovieNameCht == movieName);

            int movieID = 1;
            int score = 0;
            foreach (var item in query)
            {
                datePicker_Date.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);   //設成跟maxdate不會打架的日期
                datePicker_StartDate.Value = item.MovieScheduleStart;
                datePicker_EndDate.Value = item.MovieScheduleEnd;
                datePicker_Date.MaxDate = item.MovieScheduleEnd;                //改了順序，避免Max<Min錯誤 (旭)
                datePicker_Date.MinDate = item.MovieScheduleStart;

                if (DateTime.Now.Date > item.MovieScheduleStart && DateTime.Now.Date<item.MovieScheduleEnd)
                    datePicker_Date.Value = DateTime.Now.Date;
                else
                    datePicker_Date.Value = item.MovieScheduleStart;

                lab_ShowMovieDuration.Text = $" {item.MovieShowLength}分鐘";
                lab_ShowMovieIntroduce.Text = $"{item.MovieInteroduce}";
                movieID = item.Movie_ID;
            }

            //顯示電影評分(旭)
            var query2 = movieEntities.MovieCmts.Where
                (x => x.Movie_ID == movieID).Select(x => x.Rate);
            if (query2.Any())
            {
                score = (int)query2.Average();
                userControl_StarRate1.ShowScore(score);
            }
            else userControl_StarRate1.ShowScore(-1);
        }
    }
}
