namespace CalculatorWin
{
    partial class CalculatorWin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_firstNum = new System.Windows.Forms.TextBox();
            this.textBox_secondNum = new System.Windows.Forms.TextBox();
            this.listBox_op = new System.Windows.Forms.ListBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.lbl_firstNum = new System.Windows.Forms.Label();
            this.lbl_secondNum = new System.Windows.Forms.Label();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_firstNum
            // 
            this.textBox_firstNum.Location = new System.Drawing.Point(90, 138);
            this.textBox_firstNum.Name = "textBox_firstNum";
            this.textBox_firstNum.Size = new System.Drawing.Size(100, 25);
            this.textBox_firstNum.TabIndex = 0;
            // 
            // textBox_secondNum
            // 
            this.textBox_secondNum.Location = new System.Drawing.Point(405, 138);
            this.textBox_secondNum.Name = "textBox_secondNum";
            this.textBox_secondNum.Size = new System.Drawing.Size(100, 25);
            this.textBox_secondNum.TabIndex = 1;
            // 
            // listBox_op
            // 
            this.listBox_op.FormattingEnabled = true;
            this.listBox_op.ItemHeight = 15;
            this.listBox_op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.listBox_op.Location = new System.Drawing.Point(245, 116);
            this.listBox_op.Name = "listBox_op";
            this.listBox_op.Size = new System.Drawing.Size(120, 94);
            this.listBox_op.TabIndex = 2;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(245, 261);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(102, 30);
            this.btn_result.TabIndex = 3;
            this.btn_result.Text = "计算结果";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(574, 137);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 25);
            this.textBox_result.TabIndex = 5;
            // 
            // lbl_firstNum
            // 
            this.lbl_firstNum.AutoSize = true;
            this.lbl_firstNum.Location = new System.Drawing.Point(76, 107);
            this.lbl_firstNum.Name = "lbl_firstNum";
            this.lbl_firstNum.Size = new System.Drawing.Size(127, 15);
            this.lbl_firstNum.TabIndex = 6;
            this.lbl_firstNum.Text = "输入第一个操作数";
            // 
            // lbl_secondNum
            // 
            this.lbl_secondNum.AutoSize = true;
            this.lbl_secondNum.Location = new System.Drawing.Point(402, 107);
            this.lbl_secondNum.Name = "lbl_secondNum";
            this.lbl_secondNum.Size = new System.Drawing.Size(127, 15);
            this.lbl_secondNum.TabIndex = 7;
            this.lbl_secondNum.Text = "输入第二个操作数";
            // 
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Location = new System.Drawing.Point(271, 83);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(67, 15);
            this.lbl_choice.TabIndex = 8;
            this.lbl_choice.Text = "选择运算";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(604, 107);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(37, 15);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "结果";
            // 
            // CalculatorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.lbl_secondNum);
            this.Controls.Add(this.lbl_firstNum);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.listBox_op);
            this.Controls.Add(this.textBox_secondNum);
            this.Controls.Add(this.textBox_firstNum);
            this.Name = "CalculatorWin";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_firstNum;
        private System.Windows.Forms.TextBox textBox_secondNum;
        private System.Windows.Forms.ListBox listBox_op;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label lbl_firstNum;
        private System.Windows.Forms.Label lbl_secondNum;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Label lbl_result;
    }
}

