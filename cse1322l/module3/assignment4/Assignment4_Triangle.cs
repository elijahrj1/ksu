using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Triangle : Shape
    {
        private double side3;

        public Triangle() {}

        public Triangle(double s1, double s2, double s3) : base(s1, s2)
        {
            this.SetSide1(s1);
            this.SetSide2(s2);
            SetSide3(s3);
        }

        public double GetSide3()
        {
            return side3;
        }

        public void SetSide3(double s3)
        {
            s3 = side3;
        }

        public new double CalculateArea()
        {
            double peri = (this.GetSide1() + this.GetSide2() + this.GetSide3());
            return Math.Sqrt(peri * (peri - this.GetSide1()) * (peri - this.GetSide2()) * (peri - this.GetSide3())); //Heron's formula, thank you @T-Cope/Battle Mittens
        }

        public new double CalculatePerimeter()
        {
            return (this.GetSide1() + this.GetSide2() + this.GetSide3());
        }

        public override string ToString()
        {
            return "Triangle Side 1= " + this.GetSide1() + "\nTriangle Side 2= " + this.GetSide2() + "\nTriangle Side 3= " + this.GetSide3() + "\nArea of Triangle= " + this.CalculateArea() + "\nPerimeter of Triangle= " + this.CalculatePerimeter();
        }
    }
}
