using System;

namespace lab_1
{
    public class Lab1
    {
        public static void Main(string[] args)
        {
            int i, j, scale = 9;
            int x = 1, z = 1;

            // pattern B
            Console.WriteLine("Pattern B");
            for (i = 0; i < scale; i++)
            {
                for (j = 0; j < scale; j++)
                {
                    if (i + j < scale - 1)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }

            // pattern C
            Console.WriteLine();
            Console.WriteLine("Pattern C");
            for (i = 0; i < scale; i++)
            {
                for (j = 0; j < scale; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            // pattern D
            Console.WriteLine();
            Console.WriteLine("Pattern D");
            for (i = 0; i >= 0; i += x)
            {
                for (j = 0; j >= 0; j = j + z)
                {
                    if (i + j >= scale / 2)
                    {
                        Console.Write("* ");
                    }
                    else if (z == 1)
                    {
                        Console.Write("- ");
                    }

                    if (j >= scale / 2)
                    {
                        z = -1;
                    }
                }
                Console.WriteLine();
                if (i >= scale / 2)
                {
                    x = -1;
                }
            }
        }
    }
}
