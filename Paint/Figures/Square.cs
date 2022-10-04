using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Square : Shape
    {
        public static void MakeNewSquare()
        {
            Console.Write("Enter width:");
            int width = int.Parse(Console.ReadLine());
            var square = new Square(width);
           
            square.Print();
        }
        public int Width { get; set; }
        public Square(int width)
        {
            Width = width;
          
        }
        public override void Print()
        {

            for (int i = 0; i <= Width; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
