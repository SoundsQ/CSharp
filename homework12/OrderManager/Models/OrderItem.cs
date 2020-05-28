using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderManager.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }//外键
        public Order Order { get; set; }
        [Key]
        public int ItemID { get; set; }//主键
        public double Price { get; set; }//商品单价
        public string Name { get; set; }//商品名
        public int Num { set; get; }
        public double Sum { get; set; }
        
        public OrderItem() { }
        public OrderItem(string b, double a, int n)
        {
            Sum = Price * Num;
            Price = a;
            Name = b;
            Num = n;
        }
    }
}
