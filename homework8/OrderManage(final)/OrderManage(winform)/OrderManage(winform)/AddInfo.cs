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
    public partial class AddInfo : Form
    {
        public Order NewOrder { get; set; }
        public AddInfo()
        {
            InitializeComponent();
            NewOrder = new Order();
            clientNameTbx.DataBindings.Add("Text", NewOrder, "ClientName");
            
        }

        private void AddToSaveBtn_Click(object sender, EventArgs e)
        {
            if(clientNameTbx.Text == string.Empty)
            {
                warningOrderInfoLbl.Text = "一定要输入客户名！";
                return;
            }
            this.Close();
            
        }
    }
}
