using System;

namespace HomeTask_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double c = double.Parse(Console.ReadLine());

            MathHelper.TriangleExists(a, b, c);

            Console.ReadKey();
        }
    }
}
