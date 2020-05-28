using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        //初始化商店 
        List<Goods> shopgoods = new List<Goods> { new Goods(goodstype.fish, 10),
                                                  new Goods(goodstype.gun, 100),
                                                  new Goods(goodstype.wine, 15) };
        [TestMethod()]
        public void OrderServiceTest()
        {}

        [TestMethod()]
        public void addOrderTest()
        {
            //添加一个订单，验证该订单总金额是否正确
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0],1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);//总计110
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            service.addOrder(order1);
            Assert.AreEqual(service.orderList.Find(x=>x.id==1).totalprice, 110);
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            //删除一个已添加的订单，验证该订单是否为空
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);//总计110
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            service.addOrder(order1);
            service.deleteOrder(1);          //如将此语句删去，验证不通过，则该测试功能正确
            Assert.IsNull(service.orderList.Find(x => x.id == 1));
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);//总计110
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            Order order2 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            order2.addOrderItem(newItem1);
            service.addOrder(order1);
            service.modifyOrder(order2, 1);
            Assert.AreEqual(service.orderList.Find(x=>x.id==1).totalprice,10);
        }

        [TestMethod()]
        public void inquiryOrderTest()    //按订单号查询
        {   
            //验证查询到的订单和该订单是否相等
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);//总计110
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            service.addOrder(order1);
            Order test=service.inquiryOrder(1);
            Assert.AreEqual(order1, test);
        }

        [TestMethod()]
        public void inquiryOrderTest1()
        {
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            service.addOrder(order1);
            List<Order> test = service.inquiryOrder("lz");
            Assert.AreEqual(order1, test.First());
        }

        [TestMethod()]
        public void inquiryOrderTest2()
        {
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);
            Customer person1 = new Customer("lz");
            Order order1 = new Order(1, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            service.addOrder(order1);
            List<Order> test1 = service.inquiryOrder(goodstype.wine);
            Assert.IsNull(test1.FirstOrDefault());
            List<Order> test2 = service.inquiryOrder(goodstype.fish);
            Assert.AreEqual(order1, test2.First());
        }

        [TestMethod()]
        public void sortOrderTest()
        {
            OrderService service = new OrderService();
            OrderItem newItem1 = new OrderItem(shopgoods[0], 1);
            OrderItem newItem2 = new OrderItem(shopgoods[1], 1);//总计110
            Customer person1 = new Customer("lz");
            Order order1 = new Order(100, person1);
            Order order2 = new Order(2, person1);
            order1.addOrderItem(newItem1);
            order1.addOrderItem(newItem2);
            order2.addOrderItem(newItem1);
            service.addOrder(order1);
            service.addOrder(order2);
            service.sortOrder();
            Assert.AreEqual(order2, service.orderList.First());
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService service = new OrderService();
            OrderItem newItem = new OrderItem(shopgoods[1], 1);
            Customer person1 = new Customer("1");
            Order order = new Order(2575, person1);
            order.addOrderItem(newItem);
            service.addOrder(order);
            service.Export();
            Assert.IsTrue(File.Exists("order.xml"));
        }
        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            OrderService service2 = new OrderService();
            OrderItem newItem = new OrderItem(shopgoods[1], 1);
            Customer person1 = new Customer("1");
            Order order = new Order(3997, person1);
            order.addOrderItem(newItem);
            service.addOrder(order);
            service2.Import("order");
            Assert.AreEqual(service2.orderList.First(), service.orderList.First());
        }
    }
}