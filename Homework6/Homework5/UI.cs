using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Homework5
{

    class UI
    {
        public static void startMenu(List<Goods> shopgoods,OrderService obj)
        {
           do
            {
                Console.Clear();
            Console.WriteLine("--订单管理程序--");
            Console.WriteLine("按提示选择你想进行的操作：");
            Console.WriteLine("1.添加订单");
            Console.WriteLine("2.修改订单");
            Console.WriteLine("3.删除订单");
            Console.WriteLine("4.查询订单");
            Console.WriteLine("5.将已有订单序列化为XML格式");
            Console.WriteLine("6.将xml文件导入到订单");
            Console.WriteLine("请输入：");
            char op;
            char.TryParse(Console.ReadLine(), out op);
           
                switch (op)
                {
                    case '1':
                        UI.addingOrderUI(shopgoods,obj);
                        break;
                    case '2':
                        UI.modifyOrderUI(shopgoods, obj);
                        break;
                    case '3':
                        UI.deleteOrderUI(shopgoods, obj);
                        break;
                    case '4':
                        UI.inquiryOrderUI(shopgoods, obj);
                        break;
                    case '5':
                        obj.Export();
                        Console.WriteLine("已导出xml文件\n");
                        Console.ReadKey();
                        break;
                    case '6':
                        Console.Write("请输入您想导入的xml文件名\n");
                        string fileName = Console.ReadLine();
                        try
                        {
                            obj.Import(fileName);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("已导入");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("请键入数字1—6！");
                        char.TryParse(Console.ReadLine(), out op);
                        break;
                }
            } while (true);
        }
        public static void addingOrderUI(List<Goods> shopgoods, OrderService obj)
        {
            Console.Clear();

            Console.WriteLine("请输入客户名:");      //设置客户名
            string cname = Console.ReadLine();
            Customer customer = new Customer(cname);

            int id;                                  //设置订单id
            do
            {
                Random random = new Random();
                id = random.Next(0, 10000);
            } while (obj.orderList.Exists(x => x.Id == id));
            Order newOrder = new Order(id,customer);

            Console.WriteLine("--订单添加界面--");
            Console.WriteLine("以下商品可供选择~");                  //显示可选商品
            foreach(Goods x in shopgoods)
            {
                Console.WriteLine(shopgoods.IndexOf(x)+":"+x);
            }

            char flag;
            do
            {
            F:  Console.WriteLine("请分别输入商品编号和数量(输入非数字返回）");
                string guestInput = Console.ReadLine();
                string[] words = guestInput.Split(' ');               //分别获取输入的数字
                int[] input = new int[2];
                try
                { 
                    if (words[0] != "0" && words[0] != "1" && words[0] != "2"||words[1]=="")
                        throw new Exception();
                     input[0] = int.Parse(words[0]);
                     input[1] = int.Parse(words[1]);
                }
                catch (Exception e)                                  //当键入非数字或非法数字时处理异常
                {
                    obj.orderList.Remove(newOrder);                 //删除该订单后重新进入添加界面
                    Console.ReadKey();
                    Console.Clear();
                    UI.startMenu(shopgoods, obj);
                }
                try                                                
                {
                    OrderItem newOI = new OrderItem(shopgoods[input[0]], input[1]);
                    newOrder.addOrderItem(newOI);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message+"请重新输入");
                    goto F;
                }
                Console.WriteLine("是否继续添加？ 1：继续添加    其他按键：已完成");
                char.TryParse(Console.ReadLine(), out flag);
            } while (flag == '1');
            try
            {
                obj.addOrder(newOrder);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                obj.orderList.Remove(newOrder);                 //删除该订单后重新进入添加界面
                UI.addingOrderUI(shopgoods, obj);
            }
            Console.WriteLine("该订单信息为:");
            Console.WriteLine(newOrder);
            Console.ReadKey();
            Console.Clear();
            return;
        
        }
        public static void deleteOrderUI(List<Goods> shopgoods, OrderService obj)
        {
          foreach(Order x in obj.orderList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("请输入将要删除订单号(输入非数字返回）");
            int id;
            if (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.ReadKey();
                Console.Clear();
                UI.startMenu(shopgoods, obj);
            }
            try
            {
                obj.deleteOrder(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
                UI.deleteOrderUI(shopgoods, obj);
            }
            Console.WriteLine("删除成功！");
            Console.ReadKey();
            Console.Clear();
            UI.startMenu(shopgoods, obj);
        }
        public static void modifyOrderUI(List<Goods> shopgoods, OrderService obj)
        {
            foreach (Order x in obj.orderList)
            {
                Console.WriteLine(x);
                Console.WriteLine("---");
            }
            Console.WriteLine("请输入将要修改订单号(输入非数字返回)");
            int id;
            if (!Int32.TryParse(Console.ReadLine(), out id))
                return;         
            if (!obj.orderList.Exists(x => x.Id == id))
            {
                Console.WriteLine("订单不存在");
                Console.ReadKey();
                Console.Clear();
                UI.modifyOrderUI(shopgoods, obj);
            }
            Order newOrder = new Order(obj.orderList[obj.orderList.FindIndex(x => x.Id == id)].Id, obj.orderList[obj.orderList.FindIndex(x => x.Id == id)].Customer);
            Console.WriteLine("--订单修改界面--");
            Console.WriteLine("以下商品可供选择~");
            foreach (Goods x in shopgoods)
            {
                Console.WriteLine(shopgoods.IndexOf(x) + ":" + x);
            }

            char flag;
            do
            {
            E: Console.WriteLine("请分别输入商品编号和数量");
                string guestInput = Console.ReadLine();
                string[] words = guestInput.Split(' ');         //分别获取输入的数字
                int[] input = new int[2];
                try
                {
                    if (words[0] != "0" && words[0] != "1" && words[0] != "2" || words[1] == "")//to be continued
                        throw new Exception("请输入0—2来选择商品种类！");
                    input[0] = int.Parse(words[0]);
                    input[1] = int.Parse(words[1]);
                }
                catch (Exception e)                                  //当键入非数字或非法数字时处理异常
                {
                    Console.Write(e.Message);
                    obj.orderList.Remove(newOrder);                 //删除该订单后重新进入添加界面
                    Console.ReadKey();
                    UI.addingOrderUI(shopgoods, obj);
                }
                try
                {
                    OrderItem newOI = new OrderItem(shopgoods[input[0]], input[1]);
                    newOrder.addOrderItem(newOI);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "请重新输入");
                    goto E;
                }
                Console.WriteLine("是否继续添加？ 1：继续添加    其他按键：已完成");
                char.TryParse(Console.ReadLine(), out flag);
            } while (flag == '1');
            try
            {
                obj.modifyOrder(newOrder,id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                obj.orderList.Remove(newOrder);                 //删除该订单后重新进入该界面
                UI.deleteOrderUI(shopgoods, obj);
            }
            Console.WriteLine("该订单信息为:");
            Console.WriteLine(newOrder);
            Console.ReadKey();
            Console.Clear();
            UI.startMenu(shopgoods, obj);
            }
        public static void inquiryOrderUI(List<Goods> shopgoods, OrderService obj)
        {
           bool flag = true;
           do
            {
                Console.WriteLine("--查询界面--");
                Console.WriteLine("1:按订单号查询 2：按客户名查询 3：按订单所含商品种类查询 4:返回");
                char op;
                char.TryParse(Console.ReadLine(), out op);
               
           
                switch (op)
                {
                    case '1':
                        Console.WriteLine("请输入订单号：");
                        int id;
                        if (!Int32.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("请输入合法数字！");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine(obj.inquiryOrder(id));
                            Console.Read();
                            Console.Clear();
                        }
                            break;
                    case '2':
                        Console.WriteLine("请输入客户名:");
                        string str = Console.ReadLine();

                        foreach (Order x in obj.inquiryOrder(str))
                             Console.WriteLine(x);
                        Console.ReadKey();
                        Console.Clear();   
                        break;
                    case '3':
                        foreach(Goods x in shopgoods)
                        {
                            Console.Write( x+"   ");
                        }
                        Console.WriteLine("请输入商品种类：");
                        goodstype gdt ;
                        try
                        {
                            gdt = (goodstype)Enum.Parse(typeof(goodstype), Console.ReadLine());
                            foreach (Order x in obj.inquiryOrder(gdt))
                                Console.WriteLine(x);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("请输入正确种类！");
                            Console.ReadKey();
                            Console.Clear();
                            flag = false;
                        }
                        Console.Read();
                        Console.Clear();
                        break;
                    case '4':
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("请键入数字1—4！");
                        flag = false;
                        char.TryParse(Console.ReadLine(), out op);
                        break;
                }
            } while (!flag);
            Console.ReadKey();
            Console.Clear();
            return;
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            //初始化商店商品
            List<Goods> shopgoods = new List<Goods>();
            shopgoods.Add(new Goods(goodstype.fish, 10));
            shopgoods.Add(new Goods(goodstype.gun, 100));
            shopgoods.Add(new Goods(goodstype.wine, 15));
            OrderService service = new OrderService();
            UI.startMenu(shopgoods, service);
        }
    }
}
