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
                    Triangle.MakeNewTriangle();
                    break;
                case "Square":
                    Square.MakeNewSquare();
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


    }
}

