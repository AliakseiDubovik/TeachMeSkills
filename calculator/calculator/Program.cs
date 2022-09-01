using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //PerformAdd();
            //PerformSubtract();
            //PerformMultiply();
            //PerformDivide();
            PerformPercentage();


        }

        static void PerformAdd()
        {
            Console.WriteLine("Type a number, and then press Enter");
            var a = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Type a number, and then press Enter");
            var b = Convert.ToInt32(Console.ReadLine());
           
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static void PerformSubtract()
        {
            Console.WriteLine("Type a number, and then press Enter");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            var b = Convert.ToInt32(Console.ReadLine());

            int c = a - b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static void PerformMultiply()
        {
            Console.WriteLine("Type a number, and then press Enter");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            var b = Convert.ToInt32(Console.ReadLine());

            int c = a * b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static void PerformDivide()
        {
            Console.WriteLine("Type a number, and then press Enter");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            var b = Convert.ToInt32(Console.ReadLine());

            int c = a / b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static void PerformPercentage()
        {
            Console.WriteLine("Type a number, and then press Enter");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            var b = Convert.ToInt32(Console.ReadLine());

            double c = a /100 * b;
            Console.WriteLine(c);
            Console.ReadKey();
        }



    }
}