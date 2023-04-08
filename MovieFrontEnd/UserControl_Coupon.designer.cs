namespace Movie_Member
{
    partial class UserControl_Coupon
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
            this.Lab_Discount = new System.Windows.Forms.Label();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_DueDate = new System.Windows.Forms.Label();
            this.Btn_Coupon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Discount
            // 
            this.Lab_Discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lab_Discount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Discount.Location = new System.Drawing.Point(20, 22);
            this.Lab_Discount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_Discount.Name = "Lab_Discount";
            this.Lab_Discount.Size = new System.Drawing.Size(69, 69);
            this.Lab_Discount.TabIndex = 1;
            this.Lab_Discount.Text = "Discount";
            this.Lab_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_Name.Location = new System.Drawing.Point(108, 22);
            this.Lab_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(146, 24);
            this.Lab_Name.TabIndex = 2;
            this.Lab_Name.Text = "Coupon_Name";
            // 
            // Lab_DueDate
            // 
            this.Lab_DueDate.AutoSize = true;
            this.Lab_DueDate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_DueDate.Location = new System.Drawing.Point(109, 58);
            this.Lab_DueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_DueDate.Name = "Lab_DueDate";
            this.Lab_DueDate.Size = new System.Drawing.Size(74, 18);
            this.Lab_DueDate.TabIndex = 3;
            this.Lab_DueDate.Text = "Due_Date";
            // 
            // Btn_Coupon
            // 
            this.Btn_Coupon.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Coupon.Location = new System.Drawing.Point(257, 22);
            this.Btn_Coupon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Coupon.Name = "Btn_Coupon";
            this.Btn_Coupon.Size = new System.Drawing.Size(72, 69);
            this.Btn_Coupon.TabIndex = 4;
            this.Btn_Coupon.Text = "立即使用";
            this.Btn_Coupon.UseVisualStyleBackColor = false;
            this.Btn_Coupon.Click += new System.EventHandler(this.Btn_Coupon_Click);
            // 
            // UserControl_Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Coupon);
            this.Controls.Add(this.Lab_DueDate);
            this.Controls.Add(this.Lab_Name);
            this.Controls.Add(this.Lab_Discount);
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "UserControl_Coupon";
            this.Size = new System.Drawing.Size(349, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lab_Discount;
        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_DueDate;
        public System.Windows.Forms.Button Btn_Coupon;
    }
}
