using System;

namespace HomeTask_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = int.Parse(Console.ReadLine());

            MathHelper.GreatestCommonDivisor(A);

            Console.ReadKey();
        }
    }
}
