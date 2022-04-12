using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_1
{
    public static class MathHelper
    {
        internal static double ThirdSideOfTriangleFounder(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        internal static double TrianglePerimeterFounder(double a, double b, double c)
        {
            return a + b + c;
        }

        internal static double TriangleSquareFounder(double a, double b)
        {
            return 0.5 * a * b;
        }

        public static double ConeSquare(double r, double l)
        {
            return Math.PI* r *(r + l);
        }
    }
}
