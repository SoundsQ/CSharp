using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManage
{
    [Serializable]
    public class OrderItem
    {
        public int ID { get; set; }
        public double Price { get; set; }//商品单价
        public string Name { get; set; }//商品名
        public int Num { set; get; }
        public double Sum
        {
            get
            {
                return Price * Num;
            }
        }
        public OrderItem() { }
        public OrderItem(string b, double a, int n)
        {
  
            Price = a;
            Name = b;
            Num = n;
        }
    }
}
