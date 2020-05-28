using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //货物类 
    [Serializable]
    public enum goodstype: int
        {
            wine,gun,fish
        }
    [Serializable]
    public class Goods
    {
        public goodstype type;
        public double price;

        public goodstype Type { get { return type; } }
        public double Price { get { return price; } }

        public Goods() { }
        public Goods(goodstype type,double price)
        {
            this.type = type;
            this.price = price;
        }
        public override string ToString()
        {
            return Type+"";
        }
        public override bool Equals(object obj)
        {
            Goods m = obj as Goods;
            return m != null && m.type == type;
        }
    }
}
