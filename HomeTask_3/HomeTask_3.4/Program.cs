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

            double D = Math.Pow(B, 2) - 4 * A * C;

            Console.WriteLine(D);

            if (D < 0)
                Console.WriteLine("Корней нет");
            else if (D == 0)
            {
                double X = (-B) / (A * 2);
                Console.WriteLine($"X = {X}");
            }
            else
            {
                double X1 = (-B + Math.Sqrt(D)) / (A * 2);
                double X2 = (-B - Math.Sqrt(D)) / (A * 2);
                Console.WriteLine($"X1 = {X1}, X2 = {X2}");
            }

            Console.ReadKey();
        }
    }
}
