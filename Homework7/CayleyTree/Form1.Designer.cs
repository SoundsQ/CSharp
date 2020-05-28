namespace CayleyTree
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rightbranchper = new System.Windows.Forms.TextBox();
            this.tb_treedepth = new System.Windows.Forms.TextBox();
            this.tb_leftbranchper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_rightbranchth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_leftbranchth = new System.Windows.Forms.TextBox();
            this.tb_itemlength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_pencolor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "左分支长度比";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "右分支长度比";
            // 
            // tb_rightbranchper
            // 
            this.tb_rightbranchper.Location = new System.Drawing.Point(303, 20);
            this.tb_rightbranchper.Name = "tb_rightbranchper";
            this.tb_rightbranchper.Size = new System.Drawing.Size(100, 25);
            this.tb_rightbranchper.TabIndex = 9;
            this.tb_rightbranchper.Text = "0.8";
            this.tb_rightbranchper.TextChanged += new System.EventHandler(this.tb_rightbranchper_TextChanged);
            // 
            // tb_treedepth
            // 
            this.tb_treedepth.Location = new System.Drawing.Point(90, 82);
            this.tb_treedepth.Name = "tb_treedepth";
            this.tb_treedepth.Size = new System.Drawing.Size(100, 25);
            this.tb_treedepth.TabIndex = 8;
            this.tb_treedepth.Text = "10";
            this.tb_treedepth.TextChanged += new System.EventHandler(this.tb_treedepth_TextChanged);
            // 
            // tb_leftbranchper
            // 
            this.tb_leftbranchper.Location = new System.Drawing.Point(303, 82);
            this.tb_leftbranchper.Name = "tb_leftbranchper";
            this.tb_leftbranchper.Size = new System.Drawing.Size(100, 25);
            this.tb_leftbranchper.TabIndex = 10;
            this.tb_leftbranchper.Text = "0.8";
            this.tb_leftbranchper.TextChanged += new System.EventHandler(this.tb_leftbranchper_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "右分支角度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "递归深度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "左分支角度";
            // 
            // tb_rightbranchth
            // 
            this.tb_rightbranchth.Location = new System.Drawing.Point(512, 19);
            this.tb_rightbranchth.Name = "tb_rightbranchth";
            this.tb_rightbranchth.Size = new System.Drawing.Size(100, 25);
            this.tb_rightbranchth.TabIndex = 11;
            this.tb_rightbranchth.Text = "0.6";
            this.tb_rightbranchth.TextChanged += new System.EventHandler(this.tb_rightbranchth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "主干长度";
            // 
            // tb_leftbranchth
            // 
            this.tb_leftbranchth.Location = new System.Drawing.Point(512, 82);
            this.tb_leftbranchth.Name = "tb_leftbranchth";
            this.tb_leftbranchth.Size = new System.Drawing.Size(100, 25);
            this.tb_leftbranchth.TabIndex = 12;
            this.tb_leftbranchth.Text = "0.5";
            this.tb_leftbranchth.TextChanged += new System.EventHandler(this.tb_leftbranchth_TextChanged);
            // 
            // tb_itemlength
            // 
            this.tb_itemlength.Location = new System.Drawing.Point(90, 17);
            this.tb_itemlength.Name = "tb_itemlength";
            this.tb_itemlength.Size = new System.Drawing.Size(100, 25);
            this.tb_itemlength.TabIndex = 7;
            this.tb_itemlength.Text = "20";
            this.tb_itemlength.TextChanged += new System.EventHandler(this.tb_itemlength_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "画笔颜色";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_pencolor
            // 
            this.cmb_pencolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pencolor.FormattingEnabled = true;
            this.cmb_pencolor.Items.AddRange(new object[] {
            "黑色",
            "蓝色",
            "黄色",
            "红色"});
            this.cmb_pencolor.Location = new System.Drawing.Point(90, 145);
            this.cmb_pencolor.Name = "cmb_pencolor";
            this.cmb_pencolor.Size = new System.Drawing.Size(121, 23);
            this.cmb_pencolor.TabIndex = 14;
            this.cmb_pencolor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_pencolor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_itemlength);
            this.panel1.Controls.Add(this.tb_leftbranchth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_rightbranchth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_leftbranchper);
            this.panel1.Controls.Add(this.tb_treedepth);
            this.panel1.Controls.Add(this.tb_rightbranchper);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 181);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 328);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_rightbranchper;
        private System.Windows.Forms.TextBox tb_treedepth;
        private System.Windows.Forms.TextBox tb_leftbranchper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_rightbranchth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_leftbranchth;
        private System.Windows.Forms.TextBox tb_itemlength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_pencolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

