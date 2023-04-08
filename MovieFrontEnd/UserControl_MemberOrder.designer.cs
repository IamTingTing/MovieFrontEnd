namespace MovieOrderSystem
{
    partial class UserControl_MemberOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_MemberOrder));
            this.lab_movieName = new System.Windows.Forms.Label();
            this.lab_theater = new System.Windows.Forms.Label();
            this.lab_session = new System.Windows.Forms.Label();
            this.pictureBox_moviePhoto = new System.Windows.Forms.PictureBox();
            this.pictureBox_theaterInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox_sessionInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_moviePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_theaterInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sessionInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_movieName
            // 
            this.lab_movieName.AutoSize = true;
            this.lab_movieName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_movieName.Location = new System.Drawing.Point(160, 20);
            this.lab_movieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_movieName.Name = "lab_movieName";
            this.lab_movieName.Size = new System.Drawing.Size(137, 29);
            this.lab_movieName.TabIndex = 0;
            this.lab_movieName.Text = "電影名稱";
            // 
            // lab_theater
            // 
            this.lab_theater.AutoSize = true;
            this.lab_theater.BackColor = System.Drawing.Color.AliceBlue;
            this.lab_theater.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_theater.Location = new System.Drawing.Point(194, 58);
            this.lab_theater.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_theater.Name = "lab_theater";
            this.lab_theater.Size = new System.Drawing.Size(106, 24);
            this.lab_theater.TabIndex = 1;
            this.lab_theater.Text = "影廳資訊";
            // 
            // lab_session
            // 
            this.lab_session.AutoSize = true;
            this.lab_session.BackColor = System.Drawing.Color.AliceBlue;
            this.lab_session.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_session.Location = new System.Drawing.Point(194, 93);
            this.lab_session.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_session.Name = "lab_session";
            this.lab_session.Size = new System.Drawing.Size(106, 24);
            this.lab_session.TabIndex = 2;
            this.lab_session.Text = "場次時間";
            // 
            // pictureBox_moviePhoto
            // 
            this.pictureBox_moviePhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_moviePhoto.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_moviePhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_moviePhoto.Name = "pictureBox_moviePhoto";
            this.pictureBox_moviePhoto.Size = new System.Drawing.Size(152, 128);
            this.pictureBox_moviePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_moviePhoto.TabIndex = 3;
            this.pictureBox_moviePhoto.TabStop = false;
            // 
            // pictureBox_theaterInfo
            // 
            this.pictureBox_theaterInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_theaterInfo.Image")));
            this.pictureBox_theaterInfo.Location = new System.Drawing.Point(170, 58);
            this.pictureBox_theaterInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_theaterInfo.Name = "pictureBox_theaterInfo";
            this.pictureBox_theaterInfo.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_theaterInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_theaterInfo.TabIndex = 5;
            this.pictureBox_theaterInfo.TabStop = false;
            // 
            // pictureBox_sessionInfo
            // 
            this.pictureBox_sessionInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox_sessionInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sessionInfo.Image")));
            this.pictureBox_sessionInfo.Location = new System.Drawing.Point(170, 93);
            this.pictureBox_sessionInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_sessionInfo.Name = "pictureBox_sessionInfo";
            this.pictureBox_sessionInfo.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_sessionInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sessionInfo.TabIndex = 6;
            this.pictureBox_sessionInfo.TabStop = false;
            // 
            // UserControl_MemberOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox_sessionInfo);
            this.Controls.Add(this.pictureBox_theaterInfo);
            this.Controls.Add(this.pictureBox_moviePhoto);
            this.Controls.Add(this.lab_session);
            this.Controls.Add(this.lab_theater);
            this.Controls.Add(this.lab_movieName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_MemberOrder";
            this.Size = new System.Drawing.Size(441, 144);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_moviePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_theaterInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sessionInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_movieName;
        private System.Windows.Forms.Label lab_theater;
        private System.Windows.Forms.Label lab_session;
        private System.Windows.Forms.PictureBox pictureBox_moviePhoto;
        private System.Windows.Forms.PictureBox pictureBox_theaterInfo;
        private System.Windows.Forms.PictureBox pictureBox_sessionInfo;
    }
}
