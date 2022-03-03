using System;

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

            double S = Math.PI * r * (r + l);

            Console.WriteLine($"Площадь конуса равна: {S} см2");
            Console.ReadKey();
        }
    }
}
