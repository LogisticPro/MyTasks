using System;

namespace HomeTask_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число :");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число :");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число :");
            double C = double.Parse(Console.ReadLine());

            CompareHelper.CompareABC(A, B, C);                    

            Console.ReadKey();
        }
    }
}
