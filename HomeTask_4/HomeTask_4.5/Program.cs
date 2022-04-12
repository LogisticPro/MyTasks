using System;

namespace HomeTask_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            MathHelper.EvklidsGreatestDivisior(a, b);

            Console.ReadKey();
        }
    }
}
