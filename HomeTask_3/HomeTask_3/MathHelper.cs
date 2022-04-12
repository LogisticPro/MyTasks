using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_3
{
    public static class MathHelper
    {
        public static double DiscriminantFounder(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public static void TriangleExists(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a) Console.WriteLine("Такой треугольник существует!");
            else Console.WriteLine("Такого треугольника не существует!");
        }
    }
}
