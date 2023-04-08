using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrderSystem
{
    public partial class UserControl_MemberOrder : UserControl
    {
        public UserControl_MemberOrder()
        {
            InitializeComponent();
        }

        public string movieName
        {
            get
            {
                return lab_movieName.Text;
            }
            set
            {
                lab_movieName.Text = value;
            }
        }

        public string theaterInfo
        {
            get
            {
                return lab_theater.Text;
            }
            set
            {
                lab_theater.Text = value;
            }
        }

        public string sessionInfo
        {
            get
            {
                return lab_session.Text;
            }
            set
            {
                lab_session.Text = value;
            }
        }

        public int OrderIDInfo
        {
            get;set;
        }

        public byte[] MoviePoster
        {
            get
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                pictureBox_moviePhoto.Image.Save(memoryStream, ImageFormat.Png);
                byte[] bytes = memoryStream.GetBuffer();
                return bytes;
            }

            set
            {
                byte[] bytes = value;
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(bytes);
                pictureBox_moviePhoto.Image = System.Drawing.Image.FromStream(memoryStream);
            }
        }
    }
}
