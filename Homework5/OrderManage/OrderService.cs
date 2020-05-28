using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class OrderService
    {
        public List<Order> orderList { get; set; }      //订单链表

        public OrderService()
        {
            orderList = new List<Order>();
        }

        //传入订单id，返回该订单在订单链表中的索引，若订单不在订单链表中则返回-1
        private int OrderIndex(int orderId)
        {
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].id == orderId)
                {
                    return i;
                }
            }
            return -1;  //该订单不在订单链表中，返回-1
        }
        
        //根据订单号查询订单
        public List<Order> SearchOrder(int orderId)
        {
            var orderSearched = from o in orderList
                                where o.id == orderId
                                orderby o.totalPrice
                                select o;
            return orderSearched.ToList();
        }

        //根据产品名查询订单
        public List<Order> SearchOrder(string productName)
        {
            var orderSearched = orderList.Where(o =>
            {
                for (int i = 0; i < o.itemList.Count; i++)
                {
                    if (o.itemList[i].product.name == productName)
                        return true;
                }
                return false;
            }).OrderBy(o => o.totalPrice);
            return orderSearched.ToList();
        }

        //根据顾客查询订单
        public List<Order> SearchOrder(Customer customer)
        {
            var orderSearched = from o in orderList
                                where o.customer == customer
                                orderby o.totalPrice 
                                select o;
            return orderSearched.ToList();
        }

        //添加订单
        public bool AddOrder(Order orderToAdd)
        {
            bool isRepeat = OrderIndex(orderToAdd.id) != -1;
            if (isRepeat)   //订单已在订单链表中
            {
                return false; 
            }
            else          
            {
                orderList.Add(orderToAdd);
                return true;
            }
        }

        //删除订单
        public bool DeleteOrder(Order orderToDelete)
        {
            int orderIndex = OrderIndex(orderToDelete.id);
            if (orderIndex == -1)   //要删除的订单不在订单链表中
            {
                //抛出删除异常
                throw new DeleteException("The order to be deleted doesn't exist!");
                return false;
            }
            else
            {
                orderList.RemoveAt(orderIndex);
                return true;
            }
        }

        //修改订单
        public bool ModifyOrder(Order newOrder)
        {
            int orderIndex = OrderIndex(newOrder.id);
            if (orderIndex == -1)    //要修改的订单不在订单链表中
            {
                //抛出修改异常
                throw new ModifyException("The order to be modified doesn't exist!");
                return false;
            }
            else
            {
                orderList[orderIndex].ModifyItemList(newOrder.itemList);
                return true;
            }
        }

        //对保存的订单按照订单号进行排序
        public void Sorted()
        {
            orderList.Sort();
        }
    }
}
