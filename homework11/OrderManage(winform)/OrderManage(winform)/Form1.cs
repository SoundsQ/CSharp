using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;
using OrderManage2;

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
            using (var context = new OrderContext())
            {
                orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                orderlistBindingSource.ResetBindings(false);
                keywordsTbx.DataBindings.Add("Text", this, "Keywords");
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using(var context = new OrderContext())
            {
                context.Orders.Load();
                context.OrderItems.Load();
                orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();
            }
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
                using (var context = new OrderContext())
                {
                    context.Orders.Load();
                    context.OrderItems.Load();
                    orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                    itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();
                }
                
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
                   
                    currentOrder.AddItem(itemadd.NewItem);
                    using (var context = new OrderContext())
                    {
                        context.Orders.Load();
                        context.OrderItems.Load();
                        orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                        itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();
                    }

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
            service.DeleteOrder(currentOrder.OrderID);
            using (var context = new OrderContext())
            {
                context.Orders.Load();
                context.OrderItems.Load();
                orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();
            }
        }
        //删除商品
        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = "";
            Order currentOrder = orderlistBindingSource.Current as Order;
            OrderItem currentItem = itemListBindingSource.Current as OrderItem;
            currentOrder.DeleteItem(currentItem);
            
            itemListBindingSource.DataSource = currentOrder.ItemList;
            using (var context = new OrderContext())
            {
                context.Orders.Load();
                context.OrderItems.Load();
                orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (var context = new OrderContext())
            {
                InfoLbl.Text = "";
                Order currentOrder = orderlistBindingSource.Current as Order;
                context.Orders.Load();
                context.OrderItems.Load();
                if (Keywords == null || Keywords == "")
                {
                    orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList();
                    itemListBindingSource.DataSource = context.OrderItems.Local.ToBindingList();

                }
                else
                {
                    if (searchKeysCbx.Text == "按订单编号查询")
                    {
                        orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList().Where(s => s.OrderID == int.Parse(Keywords));
                    }
                    else if (searchKeysCbx.Text == "按客户查询")
                    {
                        orderlistBindingSource.DataSource = context.Orders.Local.ToBindingList().Where(s => s.ClientName == Keywords);
                    }
                    else if (searchKeysCbx.Text == "按商品名查询")
                    {
                        var result = currentOrder.ItemList.Where(s => s.Name == Keywords).ToList();
                        if (result.Count == 0)
                        {
                            InfoLbl.Text = "查询失败";
                        }
                        else
                        {
                            itemListBindingSource.DataSource = result;
                            
                            itemListBindingSource.ResetBindings(false);
                            itemDataGridView.Refresh();
                        }
                    }
                }
               
                
                orderlistBindingSource.ResetBindings(false);
                itemListBindingSource.ResetBindings(false);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            /*
            using (var context = new OrderContext())
            {
                service.Import("order");
                orderlistBindingSource.DataSource = context.Orders.Local.ToList();
                itemListBindingSource.DataSource = orderlistBindingSource;
            }
            */
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            /*
            service.Export("order");
            InfoLbl.Text = "success";
            */
        }
    }
}
