using System;

namespace HomeTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Рассчитать периметр и площадь прямоугольного треугольника

            Console.WriteLine("Введите длинну 1-го катета:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длинну 2-го катета:");
            double b = double.Parse(Console.ReadLine());

            double c = MathHelper.ThirdSideOfTriangleFounder(a, b);

            double P = MathHelper.TrianglePerimeterFounder(a, b, c);

            Console.WriteLine($"Периметр равен: {P:F1} см");

            double S = MathHelper.TriangleSquareFounder(a, b);

            Console.WriteLine($"Площадь равна: {S} см2");

            Console.ReadKey();
        }
    }
}
