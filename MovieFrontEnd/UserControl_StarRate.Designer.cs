namespace prjMovieCmt
{
    partial class UserControl_StarRate
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Star1 = new System.Windows.Forms.ToolStripButton();
            this.Star2 = new System.Windows.Forms.ToolStripButton();
            this.Star3 = new System.Windows.Forms.ToolStripButton();
            this.Star4 = new System.Windows.Forms.ToolStripButton();
            this.Star5 = new System.Windows.Forms.ToolStripButton();
            this.lblScore = new System.Windows.Forms.ToolStripLabel();
            this.StarRatingControl = new System.Windows.Forms.ToolStrip();
            this.StarRatingControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Star1
            // 
            this.Star1.AutoSize = false;
            this.Star1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star1.DoubleClickEnabled = true;
            this.Star1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Star1.Image = global::MovieFrontEnd.Properties.Resources.StarEmpty;
            this.Star1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(28, 37);
            this.Star1.Text = "1";
            this.Star1.Click += new System.EventHandler(this.StarClick);
            this.Star1.DoubleClick += new System.EventHandler(this.StarClear);
            // 
            // Star2
            // 
            this.Star2.AutoSize = false;
            this.Star2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star2.DoubleClickEnabled = true;
            this.Star2.Image = global::MovieFrontEnd.Properties.Resources.StarEmpty;
            this.Star2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(28, 37);
            this.Star2.Text = "2";
            this.Star2.Click += new System.EventHandler(this.StarClick);
            this.Star2.DoubleClick += new System.EventHandler(this.StarClear);
            // 
            // Star3
            // 
            this.Star3.AutoSize = false;
            this.Star3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star3.DoubleClickEnabled = true;
            this.Star3.Image = global::MovieFrontEnd.Properties.Resources.StarEmpty;
            this.Star3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(28, 37);
            this.Star3.Text = "3";
            this.Star3.Click += new System.EventHandler(this.StarClick);
            this.Star3.DoubleClick += new System.EventHandler(this.StarClear);
            // 
            // Star4
            // 
            this.Star4.AutoSize = false;
            this.Star4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star4.DoubleClickEnabled = true;
            this.Star4.Image = global::MovieFrontEnd.Properties.Resources.StarEmpty;
            this.Star4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(28, 37);
            this.Star4.Text = "4";
            this.Star4.Click += new System.EventHandler(this.StarClick);
            this.Star4.DoubleClick += new System.EventHandler(this.StarClear);
            // 
            // Star5
            // 
            this.Star5.AutoSize = false;
            this.Star5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star5.DoubleClickEnabled = true;
            this.Star5.Image = global::MovieFrontEnd.Properties.Resources.StarEmpty;
            this.Star5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(28, 37);
            this.Star5.Text = "5";
            this.Star5.Click += new System.EventHandler(this.StarClick);
            this.Star5.DoubleClick += new System.EventHandler(this.StarClear);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = false;
            this.lblScore.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(31, 37);
            this.lblScore.Text = "0.0";
            // 
            // StarRatingControl
            // 
            this.StarRatingControl.AllowMerge = false;
            this.StarRatingControl.AutoSize = false;
            this.StarRatingControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StarRatingControl.CanOverflow = false;
            this.StarRatingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StarRatingControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StarRatingControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.StarRatingControl.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StarRatingControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Star1,
            this.Star2,
            this.Star3,
            this.Star4,
            this.Star5,
            this.lblScore});
            this.StarRatingControl.Location = new System.Drawing.Point(0, 0);
            this.StarRatingControl.MaximumSize = new System.Drawing.Size(180, 40);
            this.StarRatingControl.MinimumSize = new System.Drawing.Size(180, 40);
            this.StarRatingControl.Name = "StarRatingControl";
            this.StarRatingControl.Padding = new System.Windows.Forms.Padding(0);
            this.StarRatingControl.Size = new System.Drawing.Size(180, 40);
            this.StarRatingControl.TabIndex = 0;
            this.StarRatingControl.Text = "Star Rating";
            // 
            // StarRate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.StarRatingControl);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaximumSize = new System.Drawing.Size(180, 40);
            this.MinimumSize = new System.Drawing.Size(180, 40);
            this.Name = "StarRate";
            this.Size = new System.Drawing.Size(180, 40);
            this.StarRatingControl.ResumeLayout(false);
            this.StarRatingControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Star1;
        private System.Windows.Forms.ToolStripButton Star2;
        private System.Windows.Forms.ToolStripButton Star3;
        private System.Windows.Forms.ToolStripButton Star4;
        private System.Windows.Forms.ToolStripButton Star5;
        private System.Windows.Forms.ToolStripLabel lblScore;
        private System.Windows.Forms.ToolStrip StarRatingControl;
    }
}
