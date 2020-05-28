using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OrderManage.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService service = new OrderService();
        [TestMethod()]
        public void AddOrderTest()
        {
            int num = 1;
            string clientName = "lw";
            service.AddOrder(num,clientName);
            Assert.IsNotNull(service.orderList[num - 1]);
        }

       

        [TestMethod()]
        public void ModifyOrderTest()
        {
            service.AddOrder(1, "lw");
            int id = 1;
            string newClientName = "lw2";
            service.ModifyOrder(id, newClientName);
            Assert.IsTrue(service.orderList[id-1].ClientName==newClientName);
        }

        [TestMethod()]
        public void ModifyItemTest()
        {
            service.AddOrder(1, "lw");
            service.orderList[0].AddItem(1, "a", 12.3, 2);
            OrderItem newItem = new OrderItem(2, "b", 15.2, 3);
            service.ModifyItem(1, 1, newItem);
            Assert.AreEqual(service.orderList[0].itemList[0],newItem);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            service.DeleteOrder(1);
            Assert.IsNotNull(service.orderList[0]);
            
        }
    

        [TestMethod()]
        public void SereachOrderTest()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            Assert.IsTrue(service.SereachOrder(1).OrderID==1&& service.SereachOrder(1).ClientName=="lw");
        }

        [TestMethod()]
        public void SereachOrderTest1()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            Assert.IsNotNull(service.SereachOrder("lw"));
        }

        [TestMethod()]
        public void SereachItemTest()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            service.orderList[0].AddItem(1, "a", 12.3, 2);
            Assert.IsNotNull(service.SereachItem("a"));
        }

        [TestMethod()]
        public void ExportTest()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            service.Export("test.xml");
            
            Assert.IsNotNull("test.xml");
        }

        [TestMethod()]
        public void ImportTest()
        {
            service.AddOrder(1, "lw");
            service.AddOrder(2, "lw2");
            service.Export("test.xml");
            service.Import("test.xml");
            Assert.IsNotNull(service.orderList[0]);
        }
    }
}