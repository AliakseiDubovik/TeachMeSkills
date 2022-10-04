using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
        class Triangle : Shape
        {
        public static void MakeNewTriangle()
        {
            Console.Write("Enter height:");
            int height = int.Parse(Console.ReadLine());
            var triangle = new Triangle(height);
            triangle.Print();
        }
        public int Height { get; set; }
            public Triangle(int height)
            {
                Height = height;
            }
            public override void  Print()
            {

                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }

            }
        }
   

}
