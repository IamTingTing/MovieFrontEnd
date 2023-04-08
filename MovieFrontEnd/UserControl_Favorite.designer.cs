namespace Movie_Member
{
    partial class UserControl_Favorite
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
            this.PB_Poster = new System.Windows.Forms.PictureBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Poster
            // 
            this.PB_Poster.Location = new System.Drawing.Point(21, 18);
            this.PB_Poster.Name = "PB_Poster";
            this.PB_Poster.Size = new System.Drawing.Size(243, 264);
            this.PB_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Poster.TabIndex = 0;
            this.PB_Poster.TabStop = false;
            // 
            // Lab_Name
            // 
            this.Lab_Name.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Name.Location = new System.Drawing.Point(-1, 302);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(293, 22);
            this.Lab_Name.TabIndex = 1;
            this.Lab_Name.Text = "label1";
            this.Lab_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Order
            // 
            this.Btn_Order.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Order.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Order.Location = new System.Drawing.Point(30, 349);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(100, 36);
            this.Btn_Order.TabIndex = 2;
            this.Btn_Order.Text = "立即訂票";
            this.Btn_Order.UseVisualStyleBackColor = false;

            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Cancel.Location = new System.Drawing.Point(152, 349);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 36);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "取消最愛";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // UserControl_Favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Order);
            this.Controls.Add(this.Lab_Name);
            this.Controls.Add(this.PB_Poster);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UserControl_Favorite";
            this.Size = new System.Drawing.Size(291, 411);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Poster;
        private System.Windows.Forms.Label Lab_Name;
        public System.Windows.Forms.Button Btn_Order;
        public System.Windows.Forms.Button Btn_Cancel;
    }
}
