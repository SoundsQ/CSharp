using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Homework5
{
    //订单服务类
    public class OrderService
    {
        public List<Order> orderList=new List<Order>();
        public OrderService() {}

        public void addOrder(Order toAdd)           //添加订单
        {
            foreach(Order x in orderList)
            {
                if (x.Equals(toAdd))                
                    throw new Exception("已存在相同订单！");                
            }
            orderList.Add(toAdd);
        }
        public void deleteOrder(int id)             //按订单号删除订单
        {
            if (orderList[orderList.FindIndex(x=>x.Id==id)] != null)
                orderList.Remove(orderList.Find(x => x.Id == id));
            else
                throw new Exception("该订单不存在！");
        }
        public void modifyOrder(Order toModify,int id)  //修改订单
        {
            if (orderList[orderList.FindIndex(x => x.Id == id)] != null)
                if (!orderList[orderList.FindIndex(x => x.Id == id)].Equals(toModify))
                {
                    int index = orderList.FindIndex(x => x.Id == id);
                    deleteOrder(id);
                    orderList.Insert(index, toModify);
                }
                else
                    throw new Exception("已存在相同订单！");
        }
        public Order inquiryOrder(int id)                      //按订单号查询
        {
            var query = from s in orderList
                        where s.Id == id
                        orderby s.Totalprice descending
                        select s;
            return query.FirstOrDefault();
        }
        public List<Order> inquiryOrder(string cname)          //按客户名查询
        {
            var query = from s in orderList
                        where s.Cname == cname
                        orderby s.Totalprice descending
                        select s;
            return query.ToList();
        }
        public List<Order> inquiryOrder(goodstype goodstype )      //按商品名称查询
        {
            var query = orderList.Where(x => x.orderItemList.Exists(y => y.thisgoods.Type == goodstype))
                                 .OrderByDescending(x => x.Totalprice);                 
            return query.ToList();
        }
        public void sortOrder()                               //按订单号排序
        {
            orderList.Sort((o1, o2) => o1.Id - o2.Id);
        }
        public void Export()                                  //序列化
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderList);
                /*foreach (Order x in orderList)
                {
                    x.exportOrderItem();
                }*/
            }

         }
        public void Import(string fileName)                   //反序列化
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.Open))
            {
                orderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }

        }
    }
}
