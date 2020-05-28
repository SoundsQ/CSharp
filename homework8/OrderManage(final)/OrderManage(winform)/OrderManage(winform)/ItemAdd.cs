using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;

namespace OrderManage_winform_
{
    public partial class ItemAdd : Form
    {
        public OrderItem NewItem { get; set; }
        public ItemAdd()
        {
            InitializeComponent();
            NewItem = new OrderItem();
            
        }

        private void AddToSaveBtn_Click(object sender, EventArgs e)
        {
            if (itemNameTbx.Text == string.Empty || itemPriceTbx.Text == string.Empty || itemNumberTbx.Text == string.Empty)
            {
                LblWarning.Text = "请输入";
                return;
            }
            else
            {
                NewItem.Name = itemNameTbx.Text;
                NewItem.Price = double.Parse(itemPriceTbx.Text);
                NewItem.Num = int.Parse(itemNumberTbx.Text);
                this.Close();
            }
        }
        //非法输入
        private void itemPriceTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
                LblWarning.Text = "input numbers";
            }
            else
                LblWarning.Text = "";
        }

        private void itemNumberTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
                LblWarning.Text = "input numbers";
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = true;
                LblWarning.Text = "input integer";
            }
            else
                LblWarning.Text = "";
        }

       
    }
}
