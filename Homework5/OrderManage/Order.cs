using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Order:IComparable
    {
        public int id { get; }                   //订单号
        public Customer customer { get; }           //订购该订单的客户
        public List<OrderItem> itemList { get; set; }           //订单明细链表
        public double totalPrice{ get; set; }               //订单总金额

        //创建一个空订单
       public Order(int orderId,Customer customer)
        {
            this.id = orderId;
            itemList = new List<OrderItem>();
            this.customer = customer;
            totalPrice = 0;
        }

        //创建一个有产品的订单
        public Order(int orderId, Customer customer, List<OrderItem>items)
        {
            this.id = orderId;
            itemList = new List<OrderItem>();
            this.customer = customer;
            totalPrice = 0;
            foreach (OrderItem item in items)
            {
                itemList.Add(item);
                totalPrice += item.totalPrice;
            }
        }

        //修改订单明细链表
        public void ModifyItemList(List<OrderItem> items)
        {
            totalPrice = 0;
            foreach (OrderItem item in items)
            {
                itemList.Add(item);
                totalPrice += item.totalPrice;
            }
        }

       //重写Equals方法
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return id == order.id;
        }

        //重写GetHashCode方法
        public override int GetHashCode()
        {
            var hashCode = -462789907;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(itemList);
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            return hashCode;
        }

        //重写ToString方法
        public override string ToString()
        {
            StringBuilder allItems = new StringBuilder();
            foreach (OrderItem item in itemList)
            {
                allItems.Append(item + "\n");
            }
            return "Order:" + "\tid--" + id + "\n" + customer + "\n" + "totalPrice--" + totalPrice + "\n" + allItems;
        }

        //IComparable接口的CompareTo方法实现
        public int CompareTo(object object2)
        {
            Order order2 = object2 as Order;
            return id - order2.id;
        }
    }
}
