using System;
using HomeTask_1;

namespace HomeTask_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычеслить площадь конуса

            Console.WriteLine("Введите радиус вращения конуса:");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите образующую конуса:");
            double l = double.Parse(Console.ReadLine());

            double S = MathHelper.ConeSquare(r, l);

            Console.WriteLine($"Площадь конуса равна: {S} см2");
            Console.ReadKey();
        }
    }
}
