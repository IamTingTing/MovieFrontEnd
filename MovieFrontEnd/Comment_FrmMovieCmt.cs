using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using MovieFrontEnd;
using prjMovieCmt;

namespace prjMovieCmt
{
    public partial class Comment_FrmMovieCmt : Form
    {
        public Comment_FrmMovieCmt()
        {
            InitializeComponent();
        }
        public Comment_FrmMovieCmt(int ID) 
        {
            InitializeComponent();
            _MemberID = ID;
            txtMemName.Text = GetMemName(ID);
            txtMemName.ReadOnly = true;
        }
        public Comment_FrmMovieCmt(int ID, int Movie_ID)
        {
            InitializeComponent();
            _MemberID = ID;
            txtMemName.Text = GetMemName(ID);
            txtMemName.ReadOnly = true;
            var q = from m in dbcontext.Movies
                    where m.Movie_ID == Movie_ID
                    select m.MovieNameCht;
            foreach (var item in q) { cmbMovie.Items.Add(item); }
            cmbMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            movieSelected = true;
            cmbMovie.SelectedIndex = 0;

        }
        private bool movieSelected=false;
        private bool cmtExisted=false;
        MovieEntities dbcontext = new MovieEntities();

        private int _MemberID = 0;
        public int MemberID 
        { get {return _MemberID; }
            set {_MemberID=value;
                
            } 
        }
        private string GetMemName(int memID)
        {
            var q=from mem in dbcontext.Members
                  where mem.MemberID== memID
                  select mem.Name;
            string result=q.First().ToString();
            return result;
        }
        private void FrmComment_Load(object sender, EventArgs e)
        {
            if (!movieSelected)
            {
                cmbMovie.Items.Clear();
                var q = from m in dbcontext.Movies
                        select m.MovieNameCht;
                foreach (var item in q) { cmbMovie.Items.Add(item); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.ReadOnly == false)
                { tb.Text = string.Empty; }
            }
            starRate1.Clear();
            //cmbMovie.SelectedIndex=0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            if (!cmtExisted)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    var q1 = from m in dbcontext.Movies
                            where m.MovieNameCht == cmbMovie.Text
                            select m.Movie_ID;
                    if (!q1.Any()) return;
                    MovieCmt movieCmt = new MovieCmt();
                    movieCmt.Created_Time = DateTime.Now;
                    movieCmt.Member_ID = MemberID;
                    movieCmt.Visible = true;
                    movieCmt.Movie_ID = q1.ToList().First();
                    movieCmt.Title = txtTitle.Text;
                    movieCmt.Text = txtText.Text;
                    movieCmt.Rate = starRate1.Value;
                    this.dbcontext.MovieCmts.Add(movieCmt);
                    dbcontext.SaveChanges();
                    ts.Complete();
                    MessageBox.Show("新增成功");
                }
            }
            else //(cmtExisted)
            {
                using (TransactionScope ts = new TransactionScope()) 
                {
                    var f = from m in dbcontext.Movies
                            where m.MovieNameCht == cmbMovie.Text
                            select m.Movie_ID;
                    int movieID=f.ToList().First();
                    var movieCmt1 = (from mc in dbcontext.MovieCmts
                            where mc.Movie_ID==movieID && mc.Member_ID==MemberID
                            select mc).FirstOrDefault();

                    if (movieCmt1 == null) return;

                    movieCmt1.Title = txtTitle.Text;
                    movieCmt1.Text = txtText.Text;
                    movieCmt1.Edited_Time = DateTime.Now;
                    movieCmt1.Movie_ID = movieID; 
                    movieCmt1.Rate = starRate1.Value;
                    dbcontext.SaveChanges();
                    ts.Complete();
                    MessageBox.Show("修改成功");

                }
            }
            ReFresh();

        }
        private void ReFresh() 
        {
            var q = from mc in dbcontext.MovieCmts
                    where mc.Movie.MovieNameCht == cmbMovie.Text && mc.Member_ID == this.MemberID
                    select new { title = mc.Title, text = mc.Text, rate = mc.Rate };
            try
            {
                txtTitle.Text = q.First().title;
                txtText.Text = q.First().text;
                starRate1.SetScore(q.First().rate);
                btnSend.Text = "更新";
                cmtExisted = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                txtText.Text = "";
                txtTitle.Text = "";
                starRate1.Clear();
                btnSend.Text = "送出";
                cmtExisted = false;
                btnDelete.Enabled = false;
            }


        }
        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ReFresh();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                var f = from m in dbcontext.Movies
                        where m.MovieNameCht == cmbMovie.Text
                        select m.Movie_ID;
                int movieID = f.ToList().First();
                var movieCmt1 = (from mc in dbcontext.MovieCmts
                                 where mc.Movie_ID == movieID && mc.Member_ID == MemberID
                                 select mc).FirstOrDefault();

                if (movieCmt1 == null) return;
                dbcontext.MovieCmts.Remove(movieCmt1);
                dbcontext.SaveChanges();
                ts.Complete();
                MessageBox.Show("刪除成功");

            }
            ReFresh();
        }
        

    }
}
