using System;

namespace Task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 200;

            int number2 = 500;

            while (number1 <= number2)
            {
                number1++;

                if(number1 % 17 == 0)
                    Console.Write(number1 + " ") ;
            }

            Console.ReadKey();
        }
    }
}
