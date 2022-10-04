using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ////var shapes = new List<IPrintable>();

                //var shapes = new List<Shape>();
                //shapes.Add(new Triangle());
                //shapes.Add(new Rectangle());
                //shapes.Add(new Square());
                //shapes.Add(new Circle());

                //foreach (Shape shape in shapes)
                //{
                //    shape.Print();
                //}
            }
            Console.WriteLine("Choose a shape to draw : \n Square \n Rectangle \n Triangle \n Circle");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "Triangle":
                    MakeNewTriangle();
                    break;
                case "Square":
                    MakeNewSquare();
                    break;
                //case "Rectangle":
                //    MakeNewRectangle();
                //    break;
                //case "Circle":
                //    MakeNewCircle();
                //    break;
                default:
                    Console.WriteLine("Enter correctly");
                    break;
            }


        }

        public static void MakeNewTriangle()
        {
            Console.Write("Enter height:");
            int height = int.Parse(Console.ReadLine());
            var triangle = new Triangle(height);
            triangle.Print();
        }
        public static void MakeNewSquare()
        {
            Console.Write("Enter width:");
            int width = int.Parse(Console.ReadLine());
            var square = new Square(width);
            square.Print();
        }

    }
}

