using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Rectangle : Shape
    {
        public Rectangle() {}

        public Rectangle(double s1, double s2) : base(s1, s2)
        {
            this.SetSide1(s1);
            this.SetSide2(s2);
        }

        public new double CalculateArea()
        {
            return base.CalculateArea();
        }

        public new double CalculatePerimeter()
        {
            return ((this.GetSide1() * 2) + (this.GetSide2() * 2));
        }

        public override string ToString()
        {
            return "Rectangle Side 1= " + this.GetSide1() + "\nRectangle Side 2= " + this.GetSide2() + "\nArea of Rectangle= " + this.CalculateArea() + "\nPerimeter of Rectangle= " + this.CalculatePerimeter();
        }
    }
}
