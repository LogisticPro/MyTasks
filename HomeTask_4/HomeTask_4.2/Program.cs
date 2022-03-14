using System;

namespace HomeTask_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (Math.Pow(i, 2) < number) Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
