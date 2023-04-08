using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFrontEnd
{
    public partial class UserControl_ShortCmt : UserControl
    {
        public UserControl_ShortCmt()
        {
            InitializeComponent();
        }
        public string MemberName 
        {
            get { return this.lblName.Text; }
            set {this.lblName.Text=value; }
        }
        public string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }
        public int Score 
        {
            get { return this.userControl_StarRate1.Value; }
            set { this.userControl_StarRate1.Value = value;
                this.userControl_StarRate1.ShowScore(value);
            }

        }
    }
}
