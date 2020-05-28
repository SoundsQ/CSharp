using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Homework3
{
    class ShapeFactory
    {
        private static Random rd = new Random();
        public static Shape GetShape(int ShapeType)//1 for rectangle,2 for square, 3 for triangle
        {
            Shape shape = null;
            switch (ShapeType)
            {
                case 1:                   
                    shape = new Rectangle(10 * rd.NextDouble(), 10 * rd.NextDouble());
                    Console.Write("Create a Rectangle");
                    break;
                case 2:
                    shape= new Square(10 * rd.NextDouble());
                    Console.Write("Create a Square");                    
                    break;
                case 3:
                    double s1, s2, s3;//create a right triangle
                    do
                    {
                        s1 = 10 * rd.NextDouble(); s2 = 10 * rd.NextDouble(); s3 = 10 * rd.NextDouble();
                    } while (s1 < 0 || s2 <0 || s3 < 0 || (s1 + s2 < s3) || (s1 + s3 < s2) || (s2 + s3 < s1));
                    Console.Write("Create a Triangle");
                    shape= new Triangle(s1, s2, s3);
                    break;
                default:
                    throw new ArgumentException("请输入1or2or3！");
            }
            return shape;
        }
        public static Shape GetShape ()
        {
            return GetShape(rd.Next(1, 4));            
        }
    }
}
