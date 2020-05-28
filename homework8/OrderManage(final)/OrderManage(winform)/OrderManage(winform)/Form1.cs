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
    public partial class Form1 : Form
    {
        public string Keywords { set; get; }
        public OrderService service = new OrderService();
        public Form1()
        {
            InitializeComponent();
            //绑定数据
            orderlistBindingSource.DataSource = service.orderList;
            keywordsTbx.DataBindings.Add("Text", this, "Keywords");
            
        }
        //添加订单
        private void addBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            AddInfo addInfo = new AddInfo();
            addInfo.ShowDialog();
            if (!string.IsNullOrEmpty(addInfo.NewOrder.ClientName))
            {
                service.AddOrder(addInfo.NewOrder);
                orderlistBindingSource.ResetBindings(false);
            }
            else
            {
                InfoLbl.Text = "添加失败";
                return;
            }
        }

        //添加商品
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            if (currentOrder == null)
            {
                InfoLbl.Text = "添加失败!当前没有订单";
                return;
            }
            else
            {
                
                ItemAdd itemadd = new ItemAdd();
                itemadd.ShowDialog();
                if (!string.IsNullOrEmpty(itemadd.NewItem.Name))
                {
                    service.orderList[currentOrder.index - 1].AddItem(itemadd.NewItem);
                    orderlistBindingSource.ResetBindings(false);
                    itemListBindingSource.ResetBindings(false);
                }
                else
                {
                    InfoLbl.Text = "添加失败";
                    return;
                }
            }
        }

        private void orderDataGridView_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            itemListBindingSource.DataSource = currentOrder.ItemList;
            
            

        }
        //删除订单
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            service.DeleteOrder(currentOrder.index);
            foreach(Order o in service.orderList)
            {
                service.UpdataIndex(o);
            }
            orderlistBindingSource.ResetBindings(false);
        }
        //删除商品
        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            OrderItem currentItem = itemListBindingSource.Current as OrderItem;
            service.orderList[currentOrder.index - 1].DeleteItem(currentItem);
            foreach(OrderItem i in service.orderList[currentOrder.index - 1].ItemList)
            {
                service.orderList[currentOrder.index - 1].UpdataItemIndex(i);
            }
            itemListBindingSource.DataSource = currentOrder.ItemList;
            orderlistBindingSource.ResetBindings(false);
            itemListBindingSource.ResetBindings(false);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            if (Keywords == null || Keywords == "")
            {
                orderlistBindingSource.DataSource = service.orderList;
                itemListBindingSource.DataSource = orderlistBindingSource;
                
            }
            else
            {
                if (searchKeysCbx.Text == "按订单编号查询")
                {
                    orderlistBindingSource.DataSource = service.orderList.Where(s => s.OrderID == int.Parse(Keywords));
                }
                else if (searchKeysCbx.Text == "按客户查询")
                {
                    orderlistBindingSource.DataSource = service.orderList.Where(s => s.ClientName == Keywords);
                }
                else if (searchKeysCbx.Text == "按商品名查询")
                {
                    var result = service.orderList[currentOrder.index - 1].ItemList.Where(s => s.Name == Keywords).ToList();
                    if (result.Count == 0)
                    {
                        InfoLbl.Text = "查询失败";
                    }
                    else
                    {
                        itemListBindingSource.DataSource = result;
                    }
                }
            }
            orderlistBindingSource.ResetBindings(false);
            itemListBindingSource.ResetBindings(false);

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            service.Import("order");
            orderlistBindingSource.DataSource = service.orderList;
            itemListBindingSource.DataSource = orderlistBindingSource;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            service.Export("order");
            InfoLbl.Text = "success";
        }
    }
}
