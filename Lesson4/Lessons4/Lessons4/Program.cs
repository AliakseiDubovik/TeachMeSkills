using System;

namespace Lessons4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string name = "Alex";
                Console.WriteLine(name);
            void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");

            int a = 10, b = 15, c = 6;
            Sum(a, b);                  // 10 + 15 = 25
            Sum(3, c);                  // 3 + 6 = 9
            Sum(14, 4 + c);             // 14 + 10 = 24
        }
      
}
}
