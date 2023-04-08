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

namespace Movie_Member
{
    public partial class UserControl_Favorite : UserControl
    {
        public UserControl_Favorite()
        {
            InitializeComponent();
        }

        public string Favor_MovieName
        {
            get { return Lab_Name.Text; }
            set { Lab_Name.Text = value;}
        }
        public System.Drawing.Image Favor_Poster
        {
            get { return PB_Poster.Image; }
            set { PB_Poster.Image = value; }
        }
        public bool Favor_Used
        {
            get { return Btn_Order.Visible; }
            set { Btn_Order.Visible = value; }
        }

        public int Favor_MovieID
        {
            get;set;
        }


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
