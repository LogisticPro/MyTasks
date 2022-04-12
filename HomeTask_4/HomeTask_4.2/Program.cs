using System;

namespace HomeTask_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число:");
            int A = int.Parse(Console.ReadLine());

            MathHelper.FindSquareNumbersLessThanA(A);

            Console.ReadKey();
        }
    }
}
