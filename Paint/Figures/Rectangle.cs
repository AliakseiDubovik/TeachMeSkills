using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Rectangle : Shape
    {
        public static void MakeNewRectangle()
        {
            Console.Write("Enter \n width: \n height:");
            int width = int.Parse(Console.ReadLine());
            
            Console.Write("Enter height:");
            int height = int.Parse(Console.ReadLine());

            var rectangle = new Rectangle(width, height);

            rectangle.Print();
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
           

        {
            Width = width;
            Height = height;

        }
        public override void Print()



    }
}
