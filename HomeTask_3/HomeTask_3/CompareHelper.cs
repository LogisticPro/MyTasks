using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_3
{
    public static class CompareHelper
    {
        static void CompareAB(double a, double b)
        {
            if (a > b) Console.WriteLine(a + b);
            else if (a == b) Console.WriteLine(a * b);
            else Console.WriteLine(a - b);
        }

        public static void CompareXY(int x, int y)
        {
            if (x > 0 && y > 0) Console.WriteLine("Точка принадлежит 1-ой четверти координатной плоскости");
            else if (x > 0 && y <= 0) Console.WriteLine("Точка принадлежит 2-ой четверти координатной плоскости");
            else if (x < 0 && y < 0) Console.WriteLine("Точка принадлежит 3-ой четверти координатной плоскости");
            else Console.WriteLine("Точка принадлежит 4-ой четверти координатной плоскости");
        }

        public static void CompareABC(double a, double b, double c)
        {
            if (a <= b && A <= c) Console.WriteLine($"{a}, {Math.Min(b, c)}, {Math.Max(b, c)}");
            else if (b <= a && b <= c) Console.WriteLine($"{b}, {Math.Min(a, c)}, {Math.Max(a, c)}");
            else if (c <= a && c <= b) Console.WriteLine($"{c}, {Math.Min(a, b)}, {Math.Max(a, b)}");
        }

        public static void DiscriminantCompare(double D, double a, double b)
        {
            if (D < 0)
                Console.WriteLine("Корней нет");
            else if (D == 0)
            {
                double x = (-b) / (a * 2);
                Console.WriteLine($"X = {X}");
            }
            else
            {
                double X1 = (-b + Math.Sqrt(D)) / (a * 2);
                double X2 = (-b - Math.Sqrt(D)) / (a * 2);
                Console.WriteLine($"X1 = {X1}, X2 = {X2}");
            }
        }
    }
}
