using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList1 = new List<OrderItem> {
                new OrderItem(new Product("西瓜", 5), 2),
                new OrderItem(new Product("苹果", 4), 3),
                new OrderItem(new Product("香蕉", 6), 2)
            };
            List<OrderItem> itemList2 = new List<OrderItem> {
                new OrderItem(new Product("菠萝", 10.2), 1),
                new OrderItem(new Product("香蕉", 6), 10),
                new OrderItem(new Product("哈密瓜", 20), 1)
            };
            List<OrderItem> itemList3 = new List<OrderItem> {
                new OrderItem(new Product("樱桃", 20.5), 1)
            };
            List<OrderItem> itemList4 = new List<OrderItem> {
                new OrderItem(new Product("车厘子", 40), 1)
            };
            Customer customer1 = new Customer(396, "dxy");
            Customer customer2 = new Customer(302, "Lisa");
            Order order1 = new Order(1, customer1, itemList1);
            Order order2 = new Order(2, customer2, itemList2);
            Order order3 = new Order(3, customer2, itemList3);
            Order order3_modified = new Order(3, customer2, itemList4);
            //添加订单order2
            bool addSuccess = orderService.AddOrder(order2);
            if (addSuccess)
                Console.WriteLine("Succeed to add "+order2);
            else
                Console.WriteLine("Fail to add! The order already exists.");
            //添加订单order3
            addSuccess = orderService.AddOrder(order3);
            if (addSuccess)
                Console.WriteLine("Succeed to add "+order3);
            else
                Console.WriteLine("Fail to add! The order already exists.");
            //添加订单order1
            addSuccess = orderService.AddOrder(order1);
            if (addSuccess)
                Console.WriteLine("Succeed to add " + order1);
            else
                Console.WriteLine("Fail to add! The order already exists.");
            //修改订单order3
            try
            {
                orderService.ModifyOrder(order3_modified);
                Console.WriteLine("The order has been successfully modified to "+ order3_modified);
            }
            catch(ModifyException e)
            {
                Console.WriteLine(e.Message);
            }
            //查询订单id为2的订单
            List<Order> orderSearched = orderService.SearchOrder(2);
            Console.WriteLine("Searched by orderId 2, the orders are");
            foreach(Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //查询商品名称为“香蕉”的订单
            orderSearched = orderService.SearchOrder("香蕉");
            Console.WriteLine("Searched by productName \"香蕉\", the orders are");
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //查询客户为customer2的订单
            orderSearched = orderService.SearchOrder(customer2);
            Console.WriteLine($"Searched by customer {customer2}, the orders are");
            foreach (Order order in orderSearched)
            {
                Console.WriteLine(order);
            }
            //删除订单order2
            try
            {
                orderService.DeleteOrder(order2);
                Console.WriteLine("Succeed to delete " + order2);
            }
            catch(DeleteException e)
            {
                Console.WriteLine(e.Message);
            }
            //输出剩余订单
            Console.WriteLine("The remaining orders are");
            foreach (Order order in orderService.orderList)
            {
                Console.WriteLine(order);
            }
            //对保存的订单按订单号进行排序
            orderService.Sorted();
            //输出排序后订单
            Console.WriteLine("After sorting, the remaining orders are");
            foreach (Order order in orderService.orderList)
            {
                Console.WriteLine(order);
            }
        }
    }
}
