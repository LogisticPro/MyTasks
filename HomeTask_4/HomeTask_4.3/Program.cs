using System;

namespace HomeTask_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            int temp = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    temp = i;
            }

            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
