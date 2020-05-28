using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Customer
    {
        public int id;                      //用户账号
        public string name;                 //用户名

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //重写ToString方法
        public override string ToString()
        {
            return "Customer:"+"\tid--"+id+"\tname--"+name;
        }
    }
}
