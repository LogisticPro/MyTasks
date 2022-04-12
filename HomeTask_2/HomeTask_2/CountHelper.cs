using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_2
{
    public static class CountHelper
    {
        public static int FirstDigit(int number)
        {
            return number / 100;
        }
        public static int SecondDigit(int number)
        {
            return (number % 100) / 10;
        }
        public static int ThirdDigit(int number)
        {
            return number % 10;
        }
        public static double RadiusFounder(double x1, double y1)
        {
           return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }

        public static bool IsZeroFractionalPart(double doubleNumber)
        {
            int intNumber = (int)doubleNumber;

            return intNumber == doubleNumber;
        }
    }
}
