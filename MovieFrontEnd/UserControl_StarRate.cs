using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMovieCmt
{
    
    public partial class UserControl_StarRate : UserControl
    {
        public UserControl_StarRate()
        {
            InitializeComponent();
            this.StarRatingControl.Renderer=new MySR();
            
        }

        #region  properties
        private System.Drawing.Color _BackColor = System.Drawing.Color.Transparent;
        public override System.Drawing.Color BackColor 
        { get { return _BackColor; }
            set 
            { _BackColor = value;
                base.BackColor = value;
                //this.ContextMenuStrip.BackColor = value;
            } 
        }



        private float _Score = 0;
        public float Score 
        {
            get { return _Score; }
            set 
            {
                if (value <=5&&value>=0) 
                _Score = value;
                lblScore.Text = _Score.ToString("0.0");
                if (value == -1)
                {
                    _Score = 0;
                    lblScore.Text = "n/a";
                }
            }
        }
        private bool _enable = true;
        public bool enable 
        {
            get { return _enable; }
            set { 
                _enable = value;
                if (!_enable)
                {
                    ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
                    foreach (ToolStripButton star in stars)
                    {
                        StarEmpty(star);
                        star.Enabled = false;
                    }
                }
                else
                {
                    ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
                    foreach (ToolStripButton star in stars)
                    {
                        StarEmpty(star);
                        star.Enabled = true;
                    }
                }
            }
        }
        private int _Value = 0;
        public int Value 
        { 
            get { return _Value; }
            set 
            { 
                if (value>=0&&value<=100)
                _Value = value; 
                
            }
        }
        private bool _ReadOnly = false;
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set { _ReadOnly = value; }
        }

        #endregion

        public void SetScore(int rate)
        {
            //this.enable = false;
            this.ReadOnly = false;
            Value = rate;
            Score = (float)rate / 20;
            int half = rate % 20;
            
            ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
            foreach (ToolStripButton star in stars) { StarEmpty(star); }
            for (int i = 0; i < rate / 20; i++)
            {
                StarFull(stars[i]);
            }
            if (half > 10)
            { StarHalf(stars[rate / 20]); }

        }

        public void ShowScore(int rate) 
        {
            this.ReadOnly = true;
            Value = rate;
            Score = (float)rate / 20;
            int half = rate % 20;
            
            ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
            foreach (ToolStripButton star in stars) { StarEmpty(star); }
            for (int i = 0; i < rate / 20; i++)
            {
                StarFull(stars[i]);
            }
            if (half > 10)
            { StarHalf(stars[rate / 20]); }

        }


        private void StarClick(object sender, EventArgs e)
        {
            int index;
            if (!_ReadOnly)
            {
                if (int.TryParse(sender.ToString(), out index))
                {
                    Score = (float)index;
                    Value = index * 20;
                    ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
                    foreach (ToolStripButton star in stars) { StarEmpty(star); }
                    for (int i = 0; i < index; i++)
                    {
                        StarFull(stars[i]);
                    }
                }
            }
        }

        public void Clear() 
        {
            this.enable = true;
            this.ReadOnly = false;
            Score = 0;
            Value = 0;
            ToolStripButton[] stars = new ToolStripButton[] { Star1, Star2, Star3, Star4, Star5 };
            foreach (ToolStripButton star in stars)  { StarEmpty(star);  }
            
        }
        private void StarClear(object sender, EventArgs e)
        {
            Clear();
           
        }
        #region draw stars

        private void StarFull(ToolStripButton btn)
        {
            if (!ReadOnly)
            { btn.Image = MovieFrontEnd.Properties.Resources.StarFull; }
            else 
            { btn.Image = MovieFrontEnd.Properties.Resources.StarFullBlue; }
        }
        private void StarEmpty(ToolStripButton btn)
        {
            if (!ReadOnly)
            { btn.Image = MovieFrontEnd.Properties.Resources.StarEmpty; }
            else
            { btn.Image = MovieFrontEnd.Properties.Resources.StarEmptyBlue; }
        }
        private void StarHalf(ToolStripButton btn)
        {
            if (!ReadOnly)
            {
                btn.Image = MovieFrontEnd.Properties.Resources.StarHalf;
            }
            else
            { btn.Image = MovieFrontEnd.Properties.Resources.StarHalfBlue; }
        }

        #endregion

    }
    public class MySR : ToolStripSystemRenderer
    {
        public MySR() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }
}
