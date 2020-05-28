using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
        class Rectangle : Shape
        {
            private double width, height, area;
            public double Area
            {
                get { return area; }
            }

            public Rectangle(double width, double height)
            {
                if (width>0&&height>0)
                {
                    this.width = width;
                    this.height = height;
                    this.area = width * height;
                }
                else
                    throw new ArgumentException("非法构造！");
            }

    }
        class Square : Rectangle
        {
            public Square(double side):base(side,side)
        {
            
        }

        }
        class Triangle : Shape
        {
            private double side1, side2, side3;
            private double area;

           /* public bool isRight()
            {
                return this.side1 > 0 && this.side2 > 0 && this.side3 > 0 && (this.side1 + this.side2 > this.side3) || (this.side1 + this.side3 > this.side2) || (this.side2 + this.side3 > this.side1);
            }*/
            public Triangle(double s1, double s2, double s3)
            {
                if (s1 > 0 && s2 > 0 && s3 > 0 && ((s1 + s2 > s3) || (s1 + s3 >s2) || (s2 + s3 > s1)))
                {
                    double p = (s1 + s2 + s3) / 2;
                    side1 = s1;
                    side2 = s2;
                    side3 = s3;
                    this.area = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
                }
                else
                    throw new ArgumentException("非法构造！");

            }
            public double Area
            {
                get { return area; }        
            }
        }
   
}
