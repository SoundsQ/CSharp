using System;
using System.Collections.Generic;
using System.Text;

/*namespace OrderManage
{
    class Info
    {
        public int OpNum { get; set; }//主菜单操作符
        public int OrderNum { get; set; }
        public int ItemNum { get; set; }
        public int SereachOp { get; set; }//查询操作符
  

        public OrderService service = new OrderService();

        public Info()
        {
            OrderNum = 0;
            ItemNum = 0;
        }

        public void OpInfo()
        {
            Console.WriteLine("1.增加订单   2.修改订单   3.删除订单    4.查询订单   5.导出xml文件   6.导入xml文件");
            Console.WriteLine("输入你的选择（1-6）：");
            OpNum = int.Parse(Console.ReadLine());
            while (!(OpNum >= 1 && OpNum <= 6))
            {
                Console.WriteLine("输入非法！！请重新输入：");
                OpNum = int.Parse(Console.ReadLine());
            }
        }
        public void DoOp()
        { 
            switch (OpNum)
            {
                case 1:
                    {
                        AddOrderInfo();
                        AddItemInfo();
                        Console.WriteLine("输入s，停止加入商品，否则，输入c，继续");
                        string stopOrContinue = Console.ReadLine();
                        while (stopOrContinue != "s"&& stopOrContinue == "c")
                        {
                            AddItemInfo();
                            Console.WriteLine("输入s，停止加入商品,否则，输入c，继续");
                            stopOrContinue = Console.ReadLine();
                        }
                        Console.WriteLine("---------------------");
                        Console.WriteLine("你的订单：");
                        Console.WriteLine(service.orderList[OrderNum - 1].ToString());
                        service.orderList[OrderNum - 1].ItemList.ForEach(s => Console.WriteLine(s));//输出所有商品明细
                        Console.WriteLine("---------------------");
                        ItemNum = 0;
                        OpInfo();
                        DoOp();
                        break;
                    }
                case 2:
                    {
                        ModifyOrderInfo();
                        OpInfo();
                        DoOp();
                        break;
                    }
                case 3:
                    {
                        DeleteOrderInfo();
                        OpInfo();
                        DoOp();
                        break;
                    }
                case 4:
                    {
                        SereachInfo();
                        OpInfo();
                        DoOp();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("选择路径：");
                        string s = Console.ReadLine();
                        service.Export(s);
                        OpInfo();
                        DoOp();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("选择路径：");
                        string s = Console.ReadLine();
                        service.Import(s);
                        OpInfo();
                        DoOp();
                        break;
                    }
                default:
                    {
                        OpInfo();
                        DoOp();
                        break;
                    }
            }
        }

        public void AddOrderInfo()
        {
            OrderNum += 1;
            Console.WriteLine("请输入你的名称：");
            string username = Console.ReadLine();
            service.AddOrder(username);
            Console.WriteLine("A new order was created.");
            Console.WriteLine(service.orderList[OrderNum - 1].ToString());
        }

        public void AddItemInfo()
        {
            ItemNum += 1;
            Console.WriteLine("请输入商品名：");
            string goodsname = Console.ReadLine();
            Console.WriteLine("请输入商品价格：");
            double goodsprice = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入商品数量：");
            int n = int.Parse(Console.ReadLine()); 
            service.orderList[OrderNum - 1].AddItem(ItemNum, goodsname, goodsprice,n);
            Console.WriteLine("A new item was created.");
            service.orderList[OrderNum - 1].ItemList.ForEach(s=> Console.WriteLine(s));//输出所有商品明细
        }

        public void ModifyOrderInfo()
        {
            Console.WriteLine("输入要修改的订单号：");
            int n1 = int.Parse(Console.ReadLine());
            if(n1<=0||n1>service.orderList.Count)
            {
                throw new ArgumentException(message: "修改失败");
                
            }
            Console.WriteLine("输入你要修改的信息：1.用户名    2.订单明细    ");
            int n2 = int.Parse(Console.ReadLine());
            if(n2==1)
            {
                Console.WriteLine("输入新的用户名：");
                string newClientName = Console.ReadLine();
                service.ModifyOrder(n1, newClientName);
            }
            else if(n2==2)
            {
                Console.WriteLine("输入订单明细号：");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入商品名：");
                string goodsname = Console.ReadLine();
                Console.WriteLine("请输入商品价格：");
                double goodsprice = Double.Parse(Console.ReadLine());
                Console.WriteLine("请输入商品数量：");
                int n = int.Parse(Console.ReadLine());
                if (id > 0 && id <= service.orderList[n1 - 1].ItemList.Count && goodsprice > 0 && n > 0)
                {
                    OrderItem newItem = new OrderItem(id, goodsname, goodsprice, n);
                    service.ModifyItem(n1, id, newItem);
                    Console.WriteLine("修改成功");
                    service.orderList[n1 - 1].ToString2();
                }
                else
                {
                    Console.WriteLine("修改失败");
                    
                }
            }
        }


        public void DeleteOrderInfo()
        {
            Console.WriteLine("输入要删除的订单号：");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 <= 0 || n1 > service.orderList.Count)
            {
                throw new ArgumentException(message: "删除失败");

            }
            service.DeleteOrder(n1);
            Console.WriteLine("删除成功");
            
        }

       

        public void SereachInfo()
        {
            Console.WriteLine("1.按订单号查询       2.按客户名查询     3.查看所有订单      4.查询商品名");
            SereachOp = int.Parse(Console.ReadLine());
            if (SereachOp == 1)
            {
                Console.WriteLine("请输入要查询的订单号：");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > service.orderList.Count)
                {
                    throw new ArgumentException(message: "修改失败");

                }
                service.SereachOrder(n).ToString2();


            }
            else if(SereachOp == 2)
            {
                Console.WriteLine("请输入要查询的用户名：");
                string s = Console.ReadLine();
                service.SereachOrder(s).ForEach(p => p.ToString2());


            }
            else if(SereachOp == 3)
            {
                service.orderList.ForEach(s => s.ToString2());
            }
            else if(SereachOp == 4)
            {
                Console.WriteLine("请输入要查询的商品名：");
                string s = Console.ReadLine();
                service.SereachItem(s).ForEach(p => Console.WriteLine(p.ToString()));
            }
            else
            {
                throw new ArgumentException(message: "查询操作失败");
            }
            
        }
    }
}
*/