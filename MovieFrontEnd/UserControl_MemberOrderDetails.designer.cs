namespace MovieOrderSystem
{
    partial class UserControl_MemberOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_MemberOrderDetails));
            this.lab_seatID = new System.Windows.Forms.Label();
            this.lab_TicketClass = new System.Windows.Forms.Label();
            this.pictureBox_ticket = new System.Windows.Forms.PictureBox();
            this.pictureBox_seat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_seat)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_seatID
            // 
            this.lab_seatID.AutoSize = true;
            this.lab_seatID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_seatID.Location = new System.Drawing.Point(51, 47);
            this.lab_seatID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_seatID.Name = "lab_seatID";
            this.lab_seatID.Size = new System.Drawing.Size(131, 36);
            this.lab_seatID.TabIndex = 0;
            this.lab_seatID.Text = "座位資訊";
            // 
            // lab_TicketClass
            // 
            this.lab_TicketClass.AutoSize = true;
            this.lab_TicketClass.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_TicketClass.Location = new System.Drawing.Point(51, 15);
            this.lab_TicketClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_TicketClass.Name = "lab_TicketClass";
            this.lab_TicketClass.Size = new System.Drawing.Size(73, 36);
            this.lab_TicketClass.TabIndex = 1;
            this.lab_TicketClass.Text = "票種";
            // 
            // pictureBox_ticket
            // 
            this.pictureBox_ticket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ticket.Image")));
            this.pictureBox_ticket.Location = new System.Drawing.Point(24, 22);
            this.pictureBox_ticket.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_ticket.Name = "pictureBox_ticket";
            this.pictureBox_ticket.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ticket.TabIndex = 2;
            this.pictureBox_ticket.TabStop = false;
            // 
            // pictureBox_seat
            // 
            this.pictureBox_seat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_seat.Image")));
            this.pictureBox_seat.Location = new System.Drawing.Point(24, 53);
            this.pictureBox_seat.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_seat.Name = "pictureBox_seat";
            this.pictureBox_seat.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_seat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_seat.TabIndex = 3;
            this.pictureBox_seat.TabStop = false;
            // 
            // UserControl_MemberOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.pictureBox_seat);
            this.Controls.Add(this.pictureBox_ticket);
            this.Controls.Add(this.lab_TicketClass);
            this.Controls.Add(this.lab_seatID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_MemberOrderDetails";
            this.Size = new System.Drawing.Size(206, 97);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_seat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_seatID;
        private System.Windows.Forms.Label lab_TicketClass;
        private System.Windows.Forms.PictureBox pictureBox_ticket;
        private System.Windows.Forms.PictureBox pictureBox_seat;
    }
}
