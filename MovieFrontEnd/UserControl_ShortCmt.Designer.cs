namespace MovieFrontEnd
{
    partial class UserControl_ShortCmt
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.userControl_StarRate1 = new prjMovieCmt.UserControl_StarRate();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "TitleWWWWWWWWWWWWWWW";
            // 
            // userControl_StarRate1
            // 
            this.userControl_StarRate1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_StarRate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControl_StarRate1.enable = true;
            this.userControl_StarRate1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl_StarRate1.Location = new System.Drawing.Point(65, 3);
            this.userControl_StarRate1.MaximumSize = new System.Drawing.Size(180, 40);
            this.userControl_StarRate1.MinimumSize = new System.Drawing.Size(180, 40);
            this.userControl_StarRate1.Name = "userControl_StarRate1";
            this.userControl_StarRate1.ReadOnly = false;
            this.userControl_StarRate1.Score = 0F;
            this.userControl_StarRate1.Size = new System.Drawing.Size(180, 40);
            this.userControl_StarRate1.TabIndex = 0;
            this.userControl_StarRate1.Value = 0;
            // 
            // UserControl_ShortCmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.userControl_StarRate1);
            this.Name = "UserControl_ShortCmt";
            this.Size = new System.Drawing.Size(250, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prjMovieCmt.UserControl_StarRate userControl_StarRate1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
    }
}
