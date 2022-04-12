using System;

namespace HomeTask_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число :");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число :");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число :");
            double C = double.Parse(Console.ReadLine());

            double D = MathHelper.DiscriminantFounder(A, B, C);

            Console.WriteLine(D);

            CompareHelper.CompareDiscriminant(D, A, B);

            Console.ReadKey();
        }
    }
}
