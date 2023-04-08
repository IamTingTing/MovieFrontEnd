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
    public partial class UserControl_MemberOrderDetails : UserControl
    {
        public UserControl_MemberOrderDetails()
        {
            InitializeComponent();
        }

        public string ticketInfo
        {
            get
            {
                return lab_TicketClass.Text;
            }
            set
            {
                lab_TicketClass.Text = value;
            }
        }

        public string seatInfo
        {
            get
            {
                return lab_seatID.Text;
            }
            set
            {
                lab_seatID.Text = value;
            }
        }
    }
}
