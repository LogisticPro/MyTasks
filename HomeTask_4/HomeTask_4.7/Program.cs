using System;

namespace HomeTask_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число произвольной длины (5-8 цифр):");
            int number = int.Parse(Console.ReadLine());

            MathHelper.OddNumbersCount(number);

            Console.ReadKey();

        }
    }
}