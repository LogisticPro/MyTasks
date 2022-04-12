using System;

namespace HomeTask_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            MathHelper.CompareAandB(a, b);

            MathHelper.SumFromAtoBdividedBy7(a, b);

            Console.ReadKey();
        }
    }
}
