using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue == true)
            {
                Console.WriteLine("Type a number, and press ENTER.: /n 1 - Add /n 2 - Subtraction /n 3 - Multipliply /n 4 - Devide /n 5 - Percentage");
                string operation = Console.ReadLine();
                if (operation == "1")
                {
                    PerformAdd();
                }
                if (operation == "2")
                {
                    PerformSubtract();
                }
                if (operation == "3")

                {
                    PerformMultiply();
                }
                if (operation == "4")
                {
                    PerformDivide();
                }
                if (operation == "5")
                {
                    PerformPercentage();
                }

                shouldContinue = PerformDialogueUser();
            }




            //int  Add, Substraction, Multiply, Devide, Persentage;
            //Add = '1';
            //Substraction = '2';
            //Multiply = '3';
            //Devide = '4';
            //Persentage = '5';
            //PerformAdd();
            //PerformSubtract();
            //PerformMultiply();
            //PerformDivide();
            //PerformPercentage();
            //bool repeat =  PerformDialogueUser();
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

            double c = (double)a / 100 * b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
        static bool PerformDialogueUser()
        {
            Console.WriteLine("Want to continue?");
            string Y = Console.ReadLine();

            if (Y == "Yes")
            {

                return true;
            }
            return false;


        }



    }
}