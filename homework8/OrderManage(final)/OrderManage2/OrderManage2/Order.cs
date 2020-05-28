using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManage
{
    [Serializable]
    public class Order
    {
        public int index { get; set; }
        public int OrderID { get; set; }
        public string ClientName { get; set; }
        public double OrderSum
        {
            get
            {
                double sum = 0;
                if (ItemList != null)
                {
                    foreach (OrderItem item in ItemList)
                    {
                        sum += item.Sum;
                    }
                }
                return sum;
            }
            
        }
        public List<OrderItem> ItemList { get; set; }

        public Order() { }
        public Order(string name)
        {
            Random r = new Random();
            OrderID = Math.Abs(1000 * r.Next());
            ClientName = name;
            ItemList = new List<OrderItem>();
        }


        public void AddItem(OrderItem item)
        {
            ItemList.Add(item);
            item.ID = ItemList.IndexOf(item) + 1;
        }

        public void DeleteItem(OrderItem item)
        {
            ItemList.Remove(item);
        }
        //更新商品序号
        public void UpdataItemIndex(OrderItem item)
        {
            item.ID = ItemList.IndexOf(item) + 1;
        }

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
