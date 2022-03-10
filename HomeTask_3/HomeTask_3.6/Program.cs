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

            if ((a + b) > c && (a + c) > b && (b + c) > a) Console.WriteLine("Такой треугольник существует!");
               else Console.WriteLine("Такого треугольника не существует!");

            Console.ReadKey();
        }
    }
}
