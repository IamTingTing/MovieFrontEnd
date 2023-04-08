using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Member
{
    public partial class UserControl_Coupon : UserControl
    {
        public UserControl_Coupon()
        {
            InitializeComponent();
        }

        public string Coupon_Name
        {
            get { return Lab_Name.Text; }
            set { Lab_Name.Text = value; }
        }
        public string Coupon_Discount
        {
            get { return Lab_Discount.Text; }
            set { Lab_Discount.Text = value; }
        }
        public string Coupon_DueDate
        {
            get { return Lab_DueDate.Text; }
            set { Lab_DueDate.Text = value; }
        }
        public bool Coupon_Used
        {
            get { return Btn_Coupon.Visible; }
            set { Btn_Coupon.Visible = value;}
        }

        private void Btn_Coupon_Click(object sender, EventArgs e)
        {

        }
    }
}
