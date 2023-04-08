using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using MovieFrontEnd;

namespace prjMovie2023
{
    public partial class Movie_MovieFron_02 : Form
    {
        public Movie_MovieFron_02()
        {
            InitializeComponent();
            movieID = 1;
        }
        public Movie_MovieFron_02(int MovieID)
        {
            InitializeComponent();
            movieID = MovieID;
        }
        private int movieID { get; set; }

        MovieEntities dbMovie = new MovieEntities();

        private void frm_Movie_MovieFron_02_Load(object sender, EventArgs e)
        {
            
            timer_MovieFron_ImagesChange.Enabled = true;
            timer_MovieFron_ImagesChange.Interval = 2000;
            
            var q = from movInfo in dbMovie.Movies
                    where movInfo.Movie_ID == movieID//MovieIdShare
                    select new
                    {
                        ID = movInfo.Movie_ID,
                        NameCht = movInfo.MovieNameCht,
                        NameEng = movInfo.MovieNameEng,
                        SchedSt = movInfo.MovieScheduleStart,
                        SchedEnd = movInfo.MovieScheduleEnd,
                        Length = movInfo.MovieShowLength,
                        Trailer = movInfo.MovieTrailerLink,
                        Interoduce = movInfo.MovieInteroduce,
                        Poster = movInfo.MoviePoster,
                        Series = movInfo.Series.SeriesName,
                    };

            foreach (var item in q)
            {
                if (item.Series !="")
                {
                    lab_MovieFron_series_01.Text = item.Series + " 系列";
                }
                else
                {
                    lab_MovieFron_series_01.Text = "";
                }
                lab_MovieFron_02_MovieNameCht.Text = item.NameCht;
                //txt_MovieBack_01_MovieNameEng.Text = item.NameEng
                lab_MovieFron_Length_02.Text = (item.Length).ToString() + " 分鐘";
                txt_MovieFron_introduction_02.Text = item.Interoduce;
                linkLab_MovieFron_trailer_02.Text = item.Trailer;
                if (item.Poster.Any())
                {
                    Byte[] data = new Byte[0];
                    data = item.Poster;
                    pB_MovieFron_Poster.SizeMode = PictureBoxSizeMode.Zoom;
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        pB_MovieFron_Poster.Image = System.Drawing.Image.FromStream(stream);
                    }
                }
                var q1 = from cmt in dbMovie.MovieCmts
                         where cmt.Movie_ID == movieID
                         select cmt.Rate;

                userControl_StarRate1.Left = lab_MovieFron_02_MovieNameCht.Right + 20;
                if (q1.Any())
                {
                    userControl_StarRate1.ShowScore((int)q1.Average());
                }
                else { userControl_StarRate1.ShowScore((-1)); }
            }
            var q3 = from p3 in dbMovie.MovieCountriesLists
                     where p3.Movie_ID == movieID //MovieIdShare
                     select p3.Country.CountryName;

            lab_MovieFron_countries_02.Text = string.Empty;
            lab_MovieFron_countries_02.Text = string.Join(", ", q3.ToList());




            var q4 = from p4 in dbMovie.MovieLanguagesLists
                     where p4.Movie_ID == movieID  //MovieIdShare
                     select p4.Language.LanguageName;

            lab_MovieFron_languages_02.Text = string.Empty;
            lab_MovieFron_languages_02.Text = string.Join(", ", q4.ToList());


            var q5 = from p5 in dbMovie.MovieDirectorsLists
                     where p5.Movie_ID == movieID //MovieIdShare
                     select p5.Director.DirectorNameCht;

            lab_MovieFron_directors_02.Text = string.Empty;
            lab_MovieFron_directors_02.Text = string.Join(", ", q5.ToList());



            var q6 = from p6 in dbMovie.MovieActorsLists
                     where p6.Movie_ID == movieID //MovieIdShare
                     select p6.Actor.ActorNameCht;


            txt_MovieFron_actors_02.Text = string.Empty;
            txt_MovieFron_actors_02.Text = string.Join(", ", q6.ToList());

            ShowImages();

            //插入三筆評論
            var q7 = from p7 in dbMovie.MovieCmts
                     where p7.Movie_ID == movieID
                     select new { p7.Member.Name,p7.Title,p7.Rate };
            if (q7.Any()) 
            {
                int i = 0;
                int top = txt_MovieFron_introduction_02.Top-10;
                int right = txt_MovieFron_introduction_02.Right+10;
                foreach (var cmt in q7.Take(3).ToList())
                {
                    UserControl_ShortCmt shortCmt = new UserControl_ShortCmt();
                    shortCmt.BackColor = System.Drawing.SystemColors.HighlightText;
                    shortCmt.Location = new System.Drawing.Point(right, top+80*i);
                    shortCmt.MemberName = cmt.Name;
                    shortCmt.Name = "ShortCmt1"+i;
                    shortCmt.Score = 0;
                    shortCmt.Size = new System.Drawing.Size(265, 75);
                    shortCmt.TabIndex = 8;
                    shortCmt.Title = cmt.Title;
                    shortCmt.Score = cmt.Rate;
                    this.Controls.Add(shortCmt);
                    i++;
                }
            }

        }

        public int ImageCount = 0;
        public List<System.Drawing.Image> iLst = new List<System.Drawing.Image>();
        public void ShowImages()
        {
            var q = from p in dbMovie.MovieImagesLists
                    where p.Movie_ID == movieID
                    select new { MyImage = p.Image.MovieImage };

            this.pB_MovieFron_Images.Controls.Clear();
            this.iLst.Clear();
            foreach (var image in q)
            {
                if (image.MyImage != null)
                {
                    using (MemoryStream stream = new MemoryStream(image.MyImage))
                    {
                        iLst.Add(System.Drawing.Image.FromStream(stream));
                    }
                }
            }
        }

        private void timer_MovieFron_ImagesChange_Tick(object sender, EventArgs e)
        {
            this.pB_MovieFron_Images.Controls.Clear();
            this.pB_MovieFron_Images.Image = iLst[ImageCount];
            Thread.Sleep(1000);
            ImageCount++;

            if(ImageCount > iLst.Count -1) 
            { 
                ImageCount = 0;
            }
        }

        private void linkLab_MovieFron_trailer_02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLab_MovieFron_trailer_02.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(linkLab_MovieFron_trailer_02.Text);
        }
    }
}
