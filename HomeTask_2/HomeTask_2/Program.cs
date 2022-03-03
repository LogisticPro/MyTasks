using System;

namespace HomeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 735;

            int firstNumber = number / 100;

            int secondNumber = (number % 100) / 10;

            int thirdNumber = number % 10;

            Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber}");

            int sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
