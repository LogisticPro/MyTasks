using System;

namespace HomeTask_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число произвольной длины (5-8 цифр):");
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            while (number != 0)
            {
                if ((number % 10) % 2 != 0) counter++;

                number = number / 10;
            }

            Console.WriteLine($"Количество нечетных цифр в числе равно {counter}");
            Console.ReadKey();

        }
    }
}