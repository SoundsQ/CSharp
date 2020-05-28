using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManager.Models
{
    public class Order
    {
        
        public int OrderID { get; set; }
        public string ClientName { get; set; }
        public double OrderSum { get; set; }
       
        public List<OrderItem> ItemList { get; set; }

        public Order() { }
        public Order(string name)
        {
            Random r = new Random();
            OrderID = Math.Abs(1000 * r.Next());
            ClientName = name;
            ItemList = new List<OrderItem>();
            double sum = 0;
            if (ItemList != null)
            {
                foreach (OrderItem item in ItemList)
                {
                    sum += item.Sum;
                }
            }
            OrderSum = sum;
        }

        /*
        public void AddItem(OrderItem item)
        {
            using (var context = new OrderContext())
            {
                item.OrderID = this.OrderID;
                context.OrderItems.Add(item);
                context.SaveChanges();
            }
        }

        public void DeleteItem(OrderItem item)
        {
            using (var context = new OrderContext())
            {
                var ditem = context.OrderItems.FirstOrDefault(p => p.ItemID == item.ItemID && p.OrderID == item.OrderID);
                if (ditem != null)
                {
                    context.OrderItems.Remove(ditem);
                    context.SaveChanges();
                }
            }
        }
       */

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID &&
                   ClientName == order.ClientName &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(ItemList, order.ItemList);
        }

        public override int GetHashCode()
        {
            var hashCode = -1758130255;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(ItemList);
            return hashCode;
        }
    }
    
    

    
}