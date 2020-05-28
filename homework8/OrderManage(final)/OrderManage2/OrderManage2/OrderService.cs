using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;


namespace OrderManage
{
    public class OrderService
    {
      
        public List<Order> orderList { get; set; }
        
        public OrderService()
        {
            orderList = new List<Order>();
        }
        //添加订单
        public void AddOrder(Order o)
        {
            try
            {
                Order order = new Order(o.ClientName);
                orderList.Add(order);
                order.index = orderList.IndexOf(order) + 1;
            }
            catch
            {
                throw new Exception(message: "invalid IDinput");
            }
            
        }

        //修改订单
        public void ModifyOrder(int modifiedID,string newClientName)
        {
            if (orderList[modifiedID - 1] == null)
            {
                throw new Exception(message: "fail to modify");
            }
            else
            {
                this.orderList[modifiedID - 1].ClientName = newClientName;
            }
        }
        //修改订单明细
        public void ModifyItem(int modifiedID, int itemID,OrderItem newItem)
        {
            if (orderList[modifiedID - 1] == null || orderList[modifiedID - 1].ItemList[itemID - 1]==null)
            {
                throw new Exception(message: "fail to modify");
            }
            else
            {
                this.orderList[modifiedID - 1].ItemList[itemID - 1] = newItem;
            }       
        }

        //删除订单
        public void DeleteOrder(int deletedOrderID)
        {
            orderList.RemoveAt(deletedOrderID-1);
        }

        //更新订单序号
        public void UpdataIndex(Order o)
        {
            o.index = orderList.IndexOf(o) + 1;
        }
        
        //按订单编号查询订单
        public Order SereachOrder(int num)
        {
            if(num<=0||num>orderList.Count())
            {
                throw new Exception(message: "Fail");
            }
            return orderList[num - 1];
        }
        
        //查询相同用户的订单时以总金额升序排列，不同用户时以订单id升序排列
        public List<Order> SereachOrder(string name)
        {
            List<int> i = new List<int> { };
            foreach(Order order in orderList)
            {
                if(order.ClientName == name)
                {
                     i.Add(order.OrderID);
                }
                
            }
            if (i == null)
            {
                throw new Exception(message: "Fail");
            }
            var sereachList = from order in orderList
                              where i.Contains(order.OrderID)
                              orderby order.OrderSum
                              select order;

            List<Order> sereachResult = sereachList.ToList();
            return sereachResult;
        }
        //按商品名查询
        public List<OrderItem> SereachItem(string itemName)
        {
            List<OrderItem> sereachResult = new List<OrderItem> { };
            foreach (Order order in orderList)
            {
                foreach (OrderItem orderItem in order.ItemList)
                {
                    var sereachTemp = from item in order.ItemList
                                      where item.Name == itemName
                                      orderby item.ID
                                      select item;
                    sereachResult = sereachTemp.ToList();
                }
            }
            if(sereachResult == null)
            {
                throw new Exception(message: "fail");
            }

            return sereachResult;
        }


        public void Export(string path)
        {
            XmlSerializer xmlserialize = new XmlSerializer(typeof(List<Order>));
            using (FileStream f = new FileStream(path, FileMode.Create))
            {
                xmlserialize.Serialize(f, orderList);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xmlserialize = new XmlSerializer(typeof(List<Order>));
            using (FileStream f = new FileStream(path, FileMode.Open))
            {
                orderList = (List<Order>)xmlserialize.Deserialize(f);
            }
        }
    }
}
