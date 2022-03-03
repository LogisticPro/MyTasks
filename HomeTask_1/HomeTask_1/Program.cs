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

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            double P = a + b + c;

            string strP = string.Format("{0:0.###}", P);

            Console.WriteLine($"Периметр равен: {strP} см");

            double S = 0.5 * a * b;

            Console.WriteLine($"Площадь равна: {S} см2");

            Console.ReadKey();
        }
    }
}
