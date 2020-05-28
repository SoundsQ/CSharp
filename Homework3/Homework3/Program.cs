using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
//2. 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。
namespace Homework3
{
    class Program
    {     
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[10];
            double totalarea = 0;
            for(int i=0;i<10;i++)
            {
                shapes[i]=ShapeFactory.GetShape();
                Console.WriteLine("  its area is:"+shapes[i].Area);
                totalarea += shapes[i].Area;
            }
            Console.WriteLine("Total area is:"  +totalarea);
            Console.Read();
        }
    }
    
}

