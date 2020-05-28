namespace OrderManage_winform_
{
    partial class AddInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderInfoGbx = new System.Windows.Forms.GroupBox();
            this.warningOrderInfoLbl = new System.Windows.Forms.Label();
            this.AddToSaveBtn = new System.Windows.Forms.Button();
            this.clientNameTbx = new System.Windows.Forms.TextBox();
            this.orderInfoGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名";
            // 
            // orderInfoGbx
            // 
            this.orderInfoGbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderInfoGbx.BackColor = System.Drawing.Color.CadetBlue;
            this.orderInfoGbx.Controls.Add(this.warningOrderInfoLbl);
            this.orderInfoGbx.Controls.Add(this.AddToSaveBtn);
            this.orderInfoGbx.Controls.Add(this.clientNameTbx);
            this.orderInfoGbx.Controls.Add(this.label1);
            this.orderInfoGbx.Location = new System.Drawing.Point(12, 28);
            this.orderInfoGbx.Name = "orderInfoGbx";
            this.orderInfoGbx.Size = new System.Drawing.Size(360, 338);
            this.orderInfoGbx.TabIndex = 1;
            this.orderInfoGbx.TabStop = false;
            // 
            // warningOrderInfoLbl
            // 
            this.warningOrderInfoLbl.AutoSize = true;
            this.warningOrderInfoLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.warningOrderInfoLbl.Location = new System.Drawing.Point(122, 97);
            this.warningOrderInfoLbl.Name = "warningOrderInfoLbl";
            this.warningOrderInfoLbl.Size = new System.Drawing.Size(0, 15);
            this.warningOrderInfoLbl.TabIndex = 3;
            // 
            // AddToSaveBtn
            // 
            this.AddToSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToSaveBtn.Location = new System.Drawing.Point(110, 261);
            this.AddToSaveBtn.Name = "AddToSaveBtn";
            this.AddToSaveBtn.Size = new System.Drawing.Size(115, 28);
            this.AddToSaveBtn.TabIndex = 2;
            this.AddToSaveBtn.Text = "确定";
            this.AddToSaveBtn.UseVisualStyleBackColor = true;
            this.AddToSaveBtn.Click += new System.EventHandler(this.AddToSaveBtn_Click);
            // 
            // clientNameTbx
            // 
            this.clientNameTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNameTbx.Location = new System.Drawing.Point(122, 38);
            this.clientNameTbx.Name = "clientNameTbx";
            this.clientNameTbx.Size = new System.Drawing.Size(183, 25);
            this.clientNameTbx.TabIndex = 1;
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.orderInfoGbx);
            this.Name = "AddInfo";
            this.Text = "AddInfo";
            this.orderInfoGbx.ResumeLayout(false);
            this.orderInfoGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox orderInfoGbx;
        private System.Windows.Forms.TextBox clientNameTbx;
        private System.Windows.Forms.Button AddToSaveBtn;
        private System.Windows.Forms.Label warningOrderInfoLbl;
    }
}