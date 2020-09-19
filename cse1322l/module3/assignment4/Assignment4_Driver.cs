using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Assignment4
{
    class Driver
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            string input, input1, input2, input3;
            double s1, s2, s3;
            while(true)
            {
                Console.WriteLine("--==Menu==--");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add a Rectangle");
                Console.WriteLine("2 - Add a Triangle");
                Console.WriteLine("3 - Display All Shapes with Details");
                Console.Write("Select an Option: ");
                input = Console.ReadLine();
                int select = Convert.ToInt32(input);

                if(select == 0)
                {
                    Environment.Exit(0);
                }

                if(select == 1)
                {
                    Console.Write("Please enter 1st side for a rectangle: ");
                    input1 = Console.ReadLine();
                    s1 = Convert.ToDouble(input1);
                    Console.Write("Please enter 2nd side for a rectangle: ");
                    input2 = Console.ReadLine();
                    s2 = Convert.ToDouble(input2);
                    Rectangle re = new Rectangle(s1, s2);
                    shapes.Add(re);
                    Console.WriteLine("Done Creating Rectangle.");
                }

                if(select == 2)
                {
                    
                    Console.Write("Please enter 1st side for a triangle: ");
                    input1 = Console.ReadLine();
                    s1 = Convert.ToDouble(input1);
                    Console.Write("Please enter 2nd side for a triangle: ");
                    input2 = Console.ReadLine();
                    s2 = Convert.ToDouble(input2);
                    Console.Write("Please enter 3rd side for a triangle: ");
                    input3 = Console.ReadLine();
                    s3 = Convert.ToDouble(input3);
                    Triangle tr = new Triangle(s1, s2, s3);
                    shapes.Add(tr);
                    Console.WriteLine("Done Creating Triangle.");
                }

                if(select == 3)
                {
                    foreach(Shape aShape in shapes)
                    {
                        Console.WriteLine();
                        Console.WriteLine(aShape.ToString());
                    }
                }
            }
        }
    }
}
