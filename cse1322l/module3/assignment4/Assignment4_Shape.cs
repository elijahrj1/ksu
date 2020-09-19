using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment4
{
    class Shape
    {
        private double side1, side2;

        public Shape() {}
        public Shape(double s1, double s2)
        {
            this.SetSide1(s1);
            this.SetSide2(s2);
        }

        public double GetSide1()
        {
            return side1;
        }

        public double GetSide2()
        {
            return side2;
        }

        public void SetSide1(double s1)
        {
            s1 = side1;
        }

        public void SetSide2(double s2)
        {
            s2 = side2;
        }

        public double CalculateArea()
        {
            return (side1 * side2);
        }

        public double CalculatePerimeter()
        {
            return (side1 + side2);
        }

        public override string ToString()
        {
            return "Shape Side 1= " + this.GetSide1() + "\nShape Side 2= " + this.GetSide2() + "\nArea of Shape= " + this.CalculateArea() + "\nPerimeter of Shape= " + this.CalculatePerimeter();
        }
    }
}
