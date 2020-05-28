using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n=10;         //递归深度
        int length=20;     //主干长度
        double th1 =0.6;   //分支角度
        double th2=0.5 ;   
        double per1=0.8;   //分支长度比
        double per2=0.8;
        double th = -Math.PI / 2;  //初始分支角度
        Pen pen = Pens.Black;      //初始画笔

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel2.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, panel2.Width / 2, panel2.Height*0.75, length, th, pen);
           
        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th,Pen pen)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(pen,x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,pen);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,pen);

        }
        void drawLine(Pen pen,double x0, double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_pencolor.SelectedIndex) {
                case 0:
                    pen = Pens.Black;
                    break;
                case 1:
                    pen = Pens.Blue;
                    break;
                case 2:
                    pen = Pens.Yellow;
                    break;
                case 3:
                    pen = Pens.Red;
                    break;              
                    }
        }

        private void tb_itemlength_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tb_itemlength.Text, out length);
        }

        private void tb_treedepth_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tb_treedepth.Text, out n);
        }

        private void tb_rightbranchper_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(tb_rightbranchper.Text, out per1);
        }

        private void tb_leftbranchper_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(tb_leftbranchper.Text, out per2);
        }

        private void tb_rightbranchth_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(tb_rightbranchth.Text, out th1);
        }

        private void tb_leftbranchth_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(tb_leftbranchth.Text, out th2);
        }

    }
}
