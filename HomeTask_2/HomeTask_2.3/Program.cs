using System;

namespace HomeTask_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначно число..");
            int number = int.Parse(Console.ReadLine());

            int firstNumber = number / 100;

            int secondNumber = (number % 100) / 10;

            int thirdNumber = number % 10;

            bool result = firstNumber >= secondNumber && secondNumber > thirdNumber;

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
