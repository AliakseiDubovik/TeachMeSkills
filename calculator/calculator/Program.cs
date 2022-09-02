using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number, and press ENTER.: /n1 - Add /n 2 - Subtraction /n 3 - Multipliply /n 4 - Devide /n 5 - Percentage of the number");
            Console.ReadKey();
            PerformAdd();
            PerformSubtract();
            PerformMultiply();
            PerformDivide();
            PerformPercentage();
            bool repeat =  PerformDialogueUser();
            
            опистаь текстом пользователю, какую цифру ввести для того, чтобы выполнить определенную операцию
            записать в  переменную значение ,которое пользователь ввел в ответе на вопрос
                с помощью if проверяя переменную, в которую пользователь ввел значение вызвать метод выполняющую соответствующую операцию
как объявить как присвоиить


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

            double c = (double)a /100 * b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static bool PerformDialogueUser()
        {
            Console.WriteLine("Wont to continue?");
            string Y = Console.ReadLine();

            if (Y == "Yes")
            {

                return true;
                    }
            return false;
        
        
        }



    }
}