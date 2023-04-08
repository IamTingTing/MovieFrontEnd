namespace prjMovieCmt
{
    partial class Comment_FrmComplaint
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblCnQType = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkIsComplaint = new System.Windows.Forms.CheckBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.tabsComplaint = new System.Windows.Forms.TabControl();
            this.tabNewComplaint = new System.Windows.Forms.TabPage();
            this.tabMyCnQs = new System.Windows.Forms.TabPage();
            this.lstMyCnQs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSatisfied = new System.Windows.Forms.Button();
            this.btnReOpen = new System.Windows.Forms.Button();
            this.lblCnQ = new System.Windows.Forms.Label();
            this.txtCnQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.tabsComplaint.SuspendLayout();
            this.tabNewComplaint.SuspendLayout();
            this.tabMyCnQs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(166, 74);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(227, 28);
            this.cmbCategories.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(166, 110);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(373, 313);
            this.txtText.TabIndex = 1;
            // 
            // lblCnQType
            // 
            this.lblCnQType.AutoSize = true;
            this.lblCnQType.Location = new System.Drawing.Point(105, 77);
            this.lblCnQType.Name = "lblCnQType";
            this.lblCnQType.Size = new System.Drawing.Size(57, 20);
            this.lblCnQType.TabIndex = 2;
            this.lblCnQType.Text = "分類：";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(41, 113);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(121, 20);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "您的寶貴意見：";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.SystemColors.Info;
            this.btnSend.Location = new System.Drawing.Point(445, 431);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 39);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "送出";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(345, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkIsComplaint
            // 
            this.checkIsComplaint.AutoSize = true;
            this.checkIsComplaint.Location = new System.Drawing.Point(400, 76);
            this.checkIsComplaint.Name = "checkIsComplaint";
            this.checkIsComplaint.Size = new System.Drawing.Size(60, 24);
            this.checkIsComplaint.TabIndex = 10;
            this.checkIsComplaint.Text = "客訴";
            this.checkIsComplaint.UseVisualStyleBackColor = true;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(71, 41);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(89, 20);
            this.lblMemberName.TabIndex = 11;
            this.lblMemberName.Text = "會員姓名：";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(166, 38);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(145, 29);
            this.txtMemberName.TabIndex = 12;
            // 
            // tabsComplaint
            // 
            this.tabsComplaint.Controls.Add(this.tabNewComplaint);
            this.tabsComplaint.Controls.Add(this.tabMyCnQs);
            this.tabsComplaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsComplaint.Location = new System.Drawing.Point(0, 0);
            this.tabsComplaint.Name = "tabsComplaint";
            this.tabsComplaint.SelectedIndex = 0;
            this.tabsComplaint.Size = new System.Drawing.Size(576, 525);
            this.tabsComplaint.TabIndex = 13;
            this.tabsComplaint.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabsComplaint_Selected);
            // 
            // tabNewComplaint
            // 
            this.tabNewComplaint.Controls.Add(this.lblMemberName);
            this.tabNewComplaint.Controls.Add(this.txtMemberName);
            this.tabNewComplaint.Controls.Add(this.cmbCategories);
            this.tabNewComplaint.Controls.Add(this.txtText);
            this.tabNewComplaint.Controls.Add(this.checkIsComplaint);
            this.tabNewComplaint.Controls.Add(this.lblCnQType);
            this.tabNewComplaint.Controls.Add(this.btnSend);
            this.tabNewComplaint.Controls.Add(this.lblText);
            this.tabNewComplaint.Controls.Add(this.btnClear);
            this.tabNewComplaint.Location = new System.Drawing.Point(4, 29);
            this.tabNewComplaint.Name = "tabNewComplaint";
            this.tabNewComplaint.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewComplaint.Size = new System.Drawing.Size(568, 492);
            this.tabNewComplaint.TabIndex = 0;
            this.tabNewComplaint.Text = "提問／客訴";
            this.tabNewComplaint.UseVisualStyleBackColor = true;
            // 
            // tabMyCnQs
            // 
            this.tabMyCnQs.Controls.Add(this.lstMyCnQs);
            this.tabMyCnQs.Controls.Add(this.label1);
            this.tabMyCnQs.Controls.Add(this.groupBox1);
            this.tabMyCnQs.Controls.Add(this.lblCnQ);
            this.tabMyCnQs.Controls.Add(this.txtCnQ);
            this.tabMyCnQs.Controls.Add(this.label2);
            this.tabMyCnQs.Controls.Add(this.txtReply);
            this.tabMyCnQs.Location = new System.Drawing.Point(4, 29);
            this.tabMyCnQs.Name = "tabMyCnQs";
            this.tabMyCnQs.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyCnQs.Size = new System.Drawing.Size(568, 492);
            this.tabMyCnQs.TabIndex = 1;
            this.tabMyCnQs.Text = "進度追蹤";
            this.tabMyCnQs.UseVisualStyleBackColor = true;
            // 
            // lstMyCnQs
            // 
            this.lstMyCnQs.FormattingEnabled = true;
            this.lstMyCnQs.ItemHeight = 20;
            this.lstMyCnQs.Location = new System.Drawing.Point(8, 31);
            this.lstMyCnQs.Name = "lstMyCnQs";
            this.lstMyCnQs.Size = new System.Drawing.Size(188, 444);
            this.lstMyCnQs.TabIndex = 27;
            this.lstMyCnQs.SelectedIndexChanged += new System.EventHandler(this.lstMyCnQs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "我的客訴與提問紀錄：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatisfied);
            this.groupBox1.Controls.Add(this.btnReOpen);
            this.groupBox1.Location = new System.Drawing.Point(202, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 88);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請問對於這樣的答覆您是否滿意？";
            // 
            // btnSatisfied
            // 
            this.btnSatisfied.BackColor = System.Drawing.SystemColors.Info;
            this.btnSatisfied.Location = new System.Drawing.Point(7, 29);
            this.btnSatisfied.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisfied.Name = "btnSatisfied";
            this.btnSatisfied.Size = new System.Drawing.Size(139, 45);
            this.btnSatisfied.TabIndex = 10;
            this.btnSatisfied.Text = "滿意";
            this.btnSatisfied.UseVisualStyleBackColor = false;
            this.btnSatisfied.Click += new System.EventHandler(this.btnSatisfied_Click);
            // 
            // btnReOpen
            // 
            this.btnReOpen.BackColor = System.Drawing.SystemColors.Info;
            this.btnReOpen.Location = new System.Drawing.Point(212, 29);
            this.btnReOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnReOpen.Name = "btnReOpen";
            this.btnReOpen.Size = new System.Drawing.Size(139, 45);
            this.btnReOpen.TabIndex = 9;
            this.btnReOpen.Text = "不滿意";
            this.btnReOpen.UseVisualStyleBackColor = false;
            this.btnReOpen.Click += new System.EventHandler(this.btnReOpen_Click);
            // 
            // lblCnQ
            // 
            this.lblCnQ.AutoSize = true;
            this.lblCnQ.Location = new System.Drawing.Point(198, 8);
            this.lblCnQ.Name = "lblCnQ";
            this.lblCnQ.Size = new System.Drawing.Size(57, 20);
            this.lblCnQ.TabIndex = 24;
            this.lblCnQ.Text = "問題：";
            // 
            // txtCnQ
            // 
            this.txtCnQ.Location = new System.Drawing.Point(202, 31);
            this.txtCnQ.Multiline = true;
            this.txtCnQ.Name = "txtCnQ";
            this.txtCnQ.Size = new System.Drawing.Size(358, 160);
            this.txtCnQ.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "回應：";
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(202, 220);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(358, 160);
            this.txtReply.TabIndex = 21;
            // 
            // FrmComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(576, 525);
            this.Controls.Add(this.tabsComplaint);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmComplaint";
            this.Text = "FrmComplaint";
            this.Load += new System.EventHandler(this.FrmComplaint_Load);
            this.tabsComplaint.ResumeLayout(false);
            this.tabNewComplaint.ResumeLayout(false);
            this.tabNewComplaint.PerformLayout();
            this.tabMyCnQs.ResumeLayout(false);
            this.tabMyCnQs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblCnQType;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkIsComplaint;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TabControl tabsComplaint;
        private System.Windows.Forms.TabPage tabNewComplaint;
        private System.Windows.Forms.TabPage tabMyCnQs;
        private System.Windows.Forms.ListBox lstMyCnQs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSatisfied;
        private System.Windows.Forms.Button btnReOpen;
        private System.Windows.Forms.Label lblCnQ;
        private System.Windows.Forms.TextBox txtCnQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReply;
    }
}