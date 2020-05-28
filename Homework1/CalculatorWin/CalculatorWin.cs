using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWin
{
    public partial class CalculatorWin : Form
    {
        public CalculatorWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNum, secondNum;
            string s = textBox_firstNum.Text;
            bool isEft;//isEft表示文本框中输入字符是否能成功解析为数字，解析成功则isEft为true，反之为false。
            isEft = int.TryParse(s, out firstNum);//解析第一个操作数
            if (!isEft)//第一个操作数解析失败
            {
                lbl_firstNum.Text = "第一个操作数必须是数字";
                return;
            }
            s = textBox_secondNum.Text;
            isEft = int.TryParse(s, out secondNum);//解析第二个操作数
            if (!isEft)//第二个操作数解析失败
            {
                lbl_secondNum.Text = "第二个操作数必须是数字";
                return;
            }
            int choice = listBox_op.SelectedIndex;
            if (choice == -1)//未选择运算符
            {
                lbl_choice.Text = "需选择一种操作";
                return;
            }
            switch (choice)
            {
                case 0:
                    textBox_result.Text = $"{firstNum + secondNum}";
                    break;
                case 1:
                    textBox_result.Text = $"{firstNum - secondNum}";
                    break;
                case 2:
                    textBox_result.Text = $"{firstNum * secondNum}";
                    break;
                case 3:
                    if (secondNum == 0)
                    {
                        lbl_secondNum.Text = "错误！除数不能为0";
                    }
                    else
                    {
                        textBox_result.Text = $"{firstNum / secondNum}";
                    }
                    break;
            }
            return;
        }

    }
}
