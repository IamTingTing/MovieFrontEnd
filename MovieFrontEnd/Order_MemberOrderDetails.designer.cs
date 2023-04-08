namespace MovieOrderSystem
{
    partial class Order_MemberOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_OrderDetail = new System.Windows.Forms.Label();
            this.flowLayoutPanel_showOrderDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.lab_ticketName = new System.Windows.Forms.Label();
            this.lab_movieDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_OrderDetail
            // 
            this.lab_OrderDetail.AutoSize = true;
            this.lab_OrderDetail.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderDetail.Location = new System.Drawing.Point(12, 87);
            this.lab_OrderDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OrderDetail.Name = "lab_OrderDetail";
            this.lab_OrderDetail.Size = new System.Drawing.Size(124, 28);
            this.lab_OrderDetail.TabIndex = 5;
            this.lab_OrderDetail.Text = "票卷明細";
            // 
            // flowLayoutPanel_showOrderDetails
            // 
            this.flowLayoutPanel_showOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_showOrderDetails.AutoScroll = true;
            this.flowLayoutPanel_showOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_showOrderDetails.Location = new System.Drawing.Point(-6, 130);
            this.flowLayoutPanel_showOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_showOrderDetails.Name = "flowLayoutPanel_showOrderDetails";
            this.flowLayoutPanel_showOrderDetails.Size = new System.Drawing.Size(426, 421);
            this.flowLayoutPanel_showOrderDetails.TabIndex = 6;
            // 
            // lab_ticketName
            // 
            this.lab_ticketName.AutoSize = true;
            this.lab_ticketName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ticketName.Location = new System.Drawing.Point(13, 11);
            this.lab_ticketName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ticketName.Name = "lab_ticketName";
            this.lab_ticketName.Size = new System.Drawing.Size(106, 24);
            this.lab_ticketName.TabIndex = 1;
            this.lab_ticketName.Text = "電影名稱";
            // 
            // lab_movieDuration
            // 
            this.lab_movieDuration.AutoSize = true;
            this.lab_movieDuration.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_movieDuration.Location = new System.Drawing.Point(13, 45);
            this.lab_movieDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_movieDuration.Name = "lab_movieDuration";
            this.lab_movieDuration.Size = new System.Drawing.Size(58, 24);
            this.lab_movieDuration.TabIndex = 2;
            this.lab_movieDuration.Text = "片長";
            // 
            // Order_MemberOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 544);
            this.Controls.Add(this.flowLayoutPanel_showOrderDetails);
            this.Controls.Add(this.lab_OrderDetail);
            this.Controls.Add(this.lab_movieDuration);
            this.Controls.Add(this.lab_ticketName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order_MemberOrderDetails";
            this.Text = "Form_MemberOrderDetails";
            this.Load += new System.EventHandler(this.Order_MemberOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_OrderDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_showOrderDetails;
        private System.Windows.Forms.Label lab_ticketName;
        private System.Windows.Forms.Label lab_movieDuration;
    }
}