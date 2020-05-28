using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    //删除异常类
    class DeleteException : Exception
    {
        public DeleteException(string message) : base(message) { }
    }

    //修改异常类
    class ModifyException : Exception
    {
        public ModifyException(string message) : base(message) { }
    }
}
