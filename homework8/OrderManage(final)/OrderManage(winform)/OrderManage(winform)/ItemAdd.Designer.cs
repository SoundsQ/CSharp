namespace OrderManage_winform_
{
    partial class ItemAdd
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
            this.components = new System.ComponentModel.Container();
            this.itemInfoGbx = new System.Windows.Forms.GroupBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.itemNumberTbx = new System.Windows.Forms.TextBox();
            this.itemPriceTbx = new System.Windows.Forms.TextBox();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.itemPriceLbl = new System.Windows.Forms.Label();
            this.warningOrderInfoLbl = new System.Windows.Forms.Label();
            this.AddToSaveBtn = new System.Windows.Forms.Button();
            this.itemNameTbx = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.SumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemInfoGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemInfoGbx
            // 
            this.itemInfoGbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemInfoGbx.BackColor = System.Drawing.Color.CadetBlue;
            this.itemInfoGbx.Controls.Add(this.LblWarning);
            this.itemInfoGbx.Controls.Add(this.itemNumberTbx);
            this.itemInfoGbx.Controls.Add(this.itemPriceTbx);
            this.itemInfoGbx.Controls.Add(this.itemNumberLbl);
            this.itemInfoGbx.Controls.Add(this.itemPriceLbl);
            this.itemInfoGbx.Controls.Add(this.warningOrderInfoLbl);
            this.itemInfoGbx.Controls.Add(this.AddToSaveBtn);
            this.itemInfoGbx.Controls.Add(this.itemNameTbx);
            this.itemInfoGbx.Controls.Add(this.itemNameLbl);
            this.itemInfoGbx.Location = new System.Drawing.Point(12, 12);
            this.itemInfoGbx.Name = "itemInfoGbx";
            this.itemInfoGbx.Size = new System.Drawing.Size(390, 413);
            this.itemInfoGbx.TabIndex = 2;
            this.itemInfoGbx.TabStop = false;
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(122, 288);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 15);
            this.LblWarning.TabIndex = 10;
            // 
            // itemNumberTbx
            // 
            this.itemNumberTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNumberTbx.Location = new System.Drawing.Point(122, 161);
            this.itemNumberTbx.Name = "itemNumberTbx";
            this.itemNumberTbx.Size = new System.Drawing.Size(213, 25);
            this.itemNumberTbx.TabIndex = 8;
            this.itemNumberTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemNumberTbx_KeyPress);
            // 
            // itemPriceTbx
            // 
            this.itemPriceTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPriceTbx.Location = new System.Drawing.Point(122, 97);
            this.itemPriceTbx.Name = "itemPriceTbx";
            this.itemPriceTbx.Size = new System.Drawing.Size(213, 25);
            this.itemPriceTbx.TabIndex = 7;
            this.itemPriceTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemPriceTbx_KeyPress);
            // 
            // itemNumberLbl
            // 
            this.itemNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemNumberLbl.AutoSize = true;
            this.itemNumberLbl.Location = new System.Drawing.Point(19, 161);
            this.itemNumberLbl.Name = "itemNumberLbl";
            this.itemNumberLbl.Size = new System.Drawing.Size(67, 15);
            this.itemNumberLbl.TabIndex = 5;
            this.itemNumberLbl.Text = "商品数量";
            // 
            // itemPriceLbl
            // 
            this.itemPriceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemPriceLbl.AutoSize = true;
            this.itemPriceLbl.Location = new System.Drawing.Point(19, 97);
            this.itemPriceLbl.Name = "itemPriceLbl";
            this.itemPriceLbl.Size = new System.Drawing.Size(67, 15);
            this.itemPriceLbl.TabIndex = 4;
            this.itemPriceLbl.Text = "商品价格";
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
            this.AddToSaveBtn.Location = new System.Drawing.Point(109, 346);
            this.AddToSaveBtn.Name = "AddToSaveBtn";
            this.AddToSaveBtn.Size = new System.Drawing.Size(145, 28);
            this.AddToSaveBtn.TabIndex = 2;
            this.AddToSaveBtn.Text = "确定";
            this.AddToSaveBtn.UseVisualStyleBackColor = true;
            this.AddToSaveBtn.Click += new System.EventHandler(this.AddToSaveBtn_Click);
            // 
            // itemNameTbx
            // 
            this.itemNameTbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameTbx.Location = new System.Drawing.Point(122, 38);
            this.itemNameTbx.Name = "itemNameTbx";
            this.itemNameTbx.Size = new System.Drawing.Size(213, 25);
            this.itemNameTbx.TabIndex = 1;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(19, 41);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(52, 15);
            this.itemNameLbl.TabIndex = 0;
            this.itemNameLbl.Text = "商品名";
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.itemInfoGbx);
            this.Name = "ItemAdd";
            this.Text = "ItemAdd";
            this.itemInfoGbx.ResumeLayout(false);
            this.itemInfoGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemInfoGbx;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.Label itemPriceLbl;
        private System.Windows.Forms.Label warningOrderInfoLbl;
        private System.Windows.Forms.Button AddToSaveBtn;
        private System.Windows.Forms.TextBox itemNameTbx;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox itemNumberTbx;
        private System.Windows.Forms.TextBox itemPriceTbx;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.BindingSource SumBindingSource;
    }
}