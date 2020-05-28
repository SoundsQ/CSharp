using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Product
    {
        public string name;      //产品名
        public double price;     //产品单价

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        //重写ToString方法
        public override string ToString()
        {
            return "product:"+"\tname--"+name+"\tprice--"+price;
        }
    }
}
