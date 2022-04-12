using System;

namespace HomeTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int A = int.Parse(Console.ReadLine());

            MathHelper.DivisionByA(A);

            Console.ReadKey();
        }
    }
}
