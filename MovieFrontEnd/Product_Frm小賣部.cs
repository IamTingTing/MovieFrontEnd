using MovieFrontEnd;
using MovieOrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Frm販賣部
{
    public partial class Product_frm小賣部 : Form
    {  
        public Product_frm小賣部(int MemID)
        {
            InitializeComponent();
            Member_ID = MemID;
            IsHaveMember();       
        }

        public Product_frm小賣部(int MemID, string coupon)
        {
            InitializeComponent();
            Member_ID = MemID;
            IsHaveMember();
            txtCouponTypeID.Text = coupon;
        }

        public Product_frm小賣部()
        {
            InitializeComponent();
        }

        int Member_ID=0;

        public void IsHaveMember()
        {
            if (Member_ID.ToString() == "")
            {
                Member_ID = int.Parse(txtMember.Text);
            }
            else
            {
                txtMember.Text = Member_ID.ToString();
            }
        }

        MovieEntities dbContext = new MovieEntities();

        private void Frm小賣部_Load(object sender, EventArgs e)
        {
           
         }
        int ColaPrice = 40, ColaTotal=0;
        int SpritePrice = 40, SpriteTotal = 0;
        int FantaPrice = 40, FantaTotal = 0;
        int MilkTeaPrice=50, MilkTeaTotal = 0;
        int POPSweetPrice = 60, POPSweetTotal = 0;
        int POPSaltyPrice = 60,POPSaltyTotal = 0;
        int POPchocolatePrice=60, POPchocolateTotal = 0;
        int ChurrosPrice = 70, ChurrosTotal = 0;
        int HotdogPrice=80, HotdogTotal = 0;
        int ThorsHammerPrice = 500, ThorsHammerTotal = 0;
        int MinionsPrice = 500, MinionsTotal = 0;
        int HulkPrice = 500, HulkTotal = 0;
        int IronManPrice = 500, ironManTotal = 0;
        int TotalPrice;
 
        int ColaQty;
        int SpriteQty;
        int FantaQty;
        int MilkTeaQty;
        int POPSweetQty;
        int POPSaltyQty;
        int POPchocolateQty;
        int ChurrosQty;
        int HotDogQty;
        int ThorsHammerQty;
        int MinionsQty;
        int HulkQty;
        int IronManQty;

        string[] TotalOder = new string[13];

        private void btnMouseEnter(object sender, EventArgs e)
        {
            //Button bettons = ((Button)sender).Text;
            //this.dbContext.ProductsTypes.Select(p => new { mytip = p.Introduce });
            var q = from i in this.dbContext.ProductsTypes.AsEnumerable()
                    where i.product_Name == ((Button)sender).Text
                    select i.Introduce;
            this.toolTip1.SetToolTip(((Button)sender), q.First().ToString()); ;
        }

        public void resultstring()
        {
            txtResult.Text = TotalOder[0] + TotalOder[1] + TotalOder[2] + TotalOder[3] + TotalOder[4] +
                TotalOder[5] + TotalOder[6] + TotalOder[7] + TotalOder[8] + TotalOder[9] + TotalOder[10] + 
                TotalOder[11] + TotalOder[12] ;
            TotalPrice = ColaTotal + SpriteTotal + FantaTotal + MilkTeaTotal +
               POPSweetTotal + POPSaltyTotal + POPchocolateTotal + ChurrosTotal + HotdogTotal +
               ThorsHammerTotal + MinionsTotal + HulkTotal + ironManTotal;

            labTotal.Text = "NT$" + TotalPrice;
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            //colaNum += 1;
            ColaQty=int.Parse(this.cbCola.Text);
            ColaTotal = ColaQty * ColaPrice;
            string resultcola = "可樂  X  " + ColaQty + ", 共 NT$ " + ColaTotal + " 元 \r\n";
            TotalOder[0] = resultcola;
            resultstring();

            //TODO     
        }
        
        private void btnSprite_Click(object sender, EventArgs e)
        {
            //spriteNum += 1;
            SpriteQty = int.Parse(this.cbSprite.Text);
            SpriteTotal = SpriteQty * SpritePrice;
            string resultsprite = "雪碧  X  " + SpriteQty + ", 共 NT$ " + SpriteTotal + " 元 \r\n";
            TotalOder[1] = resultsprite;
            resultstring();
        }

        private void btnFantaOrange_Click(object sender, EventArgs e)
        {
            //fantaNum += 1;
            FantaQty = int.Parse(this.cbFanta.Text);
            FantaTotal = FantaQty * FantaPrice;
            string resultFanta = "芬達  X  " + FantaQty + ", 共 NT$ " + FantaTotal + " 元 \r\n";
            TotalOder[2] = resultFanta;
            resultstring();
        }

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            MilkTeaQty = int.Parse(this.cbMilkTea.Text);

            MilkTeaTotal = MilkTeaQty * MilkTeaPrice;
            string resultMilkTea = "奶茶  X  " + MilkTeaQty + ", 共 NT$ " + MilkTeaTotal + " 元 \r\n";
            TotalOder[3] = resultMilkTea;
            resultstring();
        }

        private void btnPOPSweet_Click(object sender, EventArgs e)
        {
            POPSweetQty= int.Parse(this.cbPOPSweet.Text);
            POPSweetTotal = POPSweetQty * POPSweetPrice;
            string resultPOPSweet = "甜味爆米花  X  " + POPSweetQty + ", 共 NT$ " + POPSweetTotal + " 元 \r\n";
            TotalOder[4] = resultPOPSweet;
            resultstring();
        }

        private void btnPOPSalty_Click(object sender, EventArgs e)
        {
            POPSaltyQty =int.Parse(this.cbPOPSalty.Text);
            POPSaltyTotal = POPSaltyQty * POPSaltyPrice;
            string resultPOPSalty = "鹹味爆米花  X  " + POPSaltyQty + ", 共 NT$ " + POPSaltyTotal+ " 元 \r\n";
            TotalOder[5] = resultPOPSalty;
            resultstring();
        } 

        private void btnPOPchocolate_Click(object sender, EventArgs e)
        {
            POPchocolateQty = int.Parse(this.cbPOPchocolate.Text);
            POPchocolateTotal = POPchocolateQty * POPchocolatePrice;
            string resultPOPChocolate = "巧克力爆米花  X  " + POPchocolateQty+ ", 共 NT$ " + POPchocolateTotal+ " 元 \r\n";
            TotalOder[6] = resultPOPChocolate;
            resultstring();
        }

        private void btnchurros_Click(object sender, EventArgs e)
        {
            ChurrosQty = int.Parse(this.cbChurros.Text);
            ChurrosTotal = ChurrosQty * ChurrosPrice;
            string resultChurros = "吉拿棒  X  " + ChurrosQty+ ", 共 NT$ " + ChurrosTotal+ " 元 \r\n";
            TotalOder[7] = resultChurros;
            resultstring();
        }

        private void btnHotDog_Click(object sender, EventArgs e)
        {
            HotDogQty = int.Parse(this.cbHotDog.Text);
            HotdogTotal = HotDogQty * HotdogPrice;
            string resultHotDog = "熱狗堡  X  " + HotDogQty + ", 共 NT$ " + HotdogTotal + " 元 \r\n";
            TotalOder[8] = resultHotDog;
            resultstring();
        }

        private void btnThorsHammer_Click(object sender, EventArgs e)
        {
            ThorsHammerQty = int.Parse(this.cbThorsHammer.Text);
            ThorsHammerTotal = ThorsHammerQty * ThorsHammerPrice;
            string resultThorsHamme = "索爾的槌子  X  " + ThorsHammerQty + ", 共 NT$ " + ThorsHammerTotal + " 元 \r\n";
            TotalOder[9] = resultThorsHamme;
            resultstring();
        }

        private void btnMinions_Click(object sender, EventArgs e)
        {
            MinionsQty = int.Parse(this.cbMinions.Text);
            MinionsTotal = MinionsQty * MinionsPrice;
            string resultminions = "小小兵爆米花桶  X  " + MinionsQty + ", 共 NT$ " + MinionsTotal + " 元 \r\n";
            TotalOder[10] = resultminions;
            resultstring();
        }

        private void btnHulk_Click(object sender, EventArgs e)
        {
            HulkQty =int.Parse(this.cbHulk.Text);
            HulkTotal = HulkQty * HulkPrice;
            string resultHulk = "浩克的頭  X  " + HulkQty + ", 共 NT$ " + HulkTotal + " 元 \r\n";
            TotalOder[11] = resultHulk;
            resultstring();
        }

        private void btnIronMan_Click(object sender, EventArgs e)
        {
            IronManQty =int.Parse(this.cbIronMan.Text);
            ironManTotal = IronManQty * IronManPrice;
            string resultIronMan = "鋼鐵人的面具  X  " + IronManQty + ", 共 NT$ " + ironManTotal + " 元 \r\n";
            TotalOder[12] = resultIronMan;
            resultstring();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ColaQty = ColaTotal= 0;
            SpriteQty = SpriteTotal = 0;
            FantaQty =FantaTotal = 0;
            MilkTeaQty =MilkTeaTotal = 0;
            POPSweetQty =POPSweetTotal = 0;
            POPSaltyQty =POPSaltyTotal = 0;
            POPchocolateQty = POPchocolateTotal = 0;
            ChurrosQty = ChurrosTotal = 0;
            HotDogQty = HotdogTotal = 0;
            ThorsHammerQty = ThorsHammerTotal = 0;
            MinionsQty = MinionsTotal = 0;
            HulkQty = HulkTotal = 0;
            IronManQty = ironManTotal = 0;
            Array.Clear(TotalOder, 0, TotalOder.Length);
            labResult.Text = "折扣後金額";
            txtCouponTypeID.Text = "";
            txtMember.Text = "";
            resultstring();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            var q = this.dbContext.CouponTypes.AsEnumerable().
                Where(c => c.Coupon_Type_ID == int.Parse(txtCouponTypeID.Text));
            int Dis=0;
            foreach(var d in q)
            {
                Dis = d.Coupon_Discount;
            }
            TotalPrice = (TotalPrice * Dis) / 10;
            labResult.Text = TotalPrice.ToString();

            //var q = from d in this.dbContext.CouponTypes.AsEnumerable()
            //        where d.Coupon_Type_ID == (Convert.ToInt32(txtCouponTypeID.Text))
            //        select d.Coupon_Discount;
             //foreach (var item in q)
            //{
            //    listBox1.Items.Add(item);
            //}
            //double resultTotal = TotalPrice * Convert.ToDouble(q.ToList()[0]);
            //labTotal.Text = "NT$" + resultTotal;
        }        

        private void btnInsert_Click(object sender, EventArgs e)
        {

            Receipt r1 = new Receipt();
            r1.Member_ID =int.Parse(txtMember.Text);
            r1.Datetime = DateTime.Now;
            dbContext.Receipts.Add(r1);
            dbContext.SaveChanges();
            
            var q = dbContext.Receipts.OrderByDescending(o=>o.Receipt_ID).FirstOrDefault();
          
            //MessageBox.Show($"{q.Receipt_ID}");

            ReceiptDetail d = new ReceiptDetail();
            d.Receipt_ID = q.Receipt_ID;

            if (ColaQty != 0)
            {
                d.Product_ID = 1;
                d.Qty = ColaQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (SpriteQty != 0)
            {
                d.Product_ID = 2;
                d.Qty = SpriteQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if ( FantaQty!= 0)
            {
                d.Product_ID =3 ;
                d.Qty =FantaQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (MilkTeaQty != 0)
            {
                d.Product_ID =4 ;
                d.Qty =MilkTeaQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (POPSweetQty != 0)
            {
                d.Product_ID =5 ;
                d.Qty = POPSweetQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if ( POPSaltyQty!= 0)
            {
                d.Product_ID =6 ;
                d.Qty = POPSaltyQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (POPchocolateQty != 0)
            {
                d.Product_ID =7 ;
                d.Qty =POPchocolateQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (ChurrosQty != 0)
            {
                d.Product_ID =8 ;
                d.Qty = ChurrosQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (HotDogQty != 0)
            {
                d.Product_ID =9 ;
                d.Qty =HotDogQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (ThorsHammerQty != 0)
            {
                d.Product_ID =10 ;
                d.Qty =ThorsHammerQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (MinionsQty != 0)
            {
                d.Product_ID =11 ;
                d.Qty =MinionsQty ;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (HulkQty != 0)
            {
                d.Product_ID =12 ;
                d.Qty = HulkQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }
            if (IronManQty != 0)
            {
                d.Product_ID = 13;
                d.Qty = IronManQty;
                dbContext.ReceiptDetails.Add(d);
                dbContext.SaveChanges();
            }


            //dbContext.SaveChanges();
            //this.Close();
            MessageBox.Show("總金額為" + TotalPrice + "元，謝謝光臨！");
            showOrderForm(Member_ID,TotalPrice);
        }

        public delegate void ShowOrderForm(int memberID,int Price);
        public event ShowOrderForm showOrderForm;
    }

}
