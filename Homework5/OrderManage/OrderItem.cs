using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class OrderItem
    {
        public Product product { get; }       //商品
        public int prdctQuantity { get; }     //商品数量
        public double totalPrice { get; }    //商品总金额

        //创建订单明细
        public OrderItem(Product product, int prdctQuantity)
        {
            this.product = product;
            this.prdctQuantity = prdctQuantity;
            totalPrice = product.price * prdctQuantity;
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return product.name == orderItem.product.name;
        }

        //重写GetHashCode方法
        public override int GetHashCode()
        {
            var hashCode = 189248349;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(product);
            hashCode = hashCode * -1521134295 + prdctQuantity.GetHashCode();
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            return hashCode;
        }

        //重写ToString方法
        public override string ToString()
        {
            return product+"\tquantity--"+prdctQuantity+"\ttotalPrice--"+totalPrice;
        }
    }
}
