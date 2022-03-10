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

            if(A <= B && A <= C) Console.WriteLine($"{A}, {Math.Min(B,C)}, {Math.Max(B, C)}");           
               else if(B <= A && B <= C) Console.WriteLine($"{B}, {Math.Min(A, C)}, {Math.Max(A, C)}");
                  else if(C <= A && C <= B) Console.WriteLine($"{C}, {Math.Min(A, B)}, {Math.Max(A, B)}");
                                               
            Console.ReadKey();
        }
    }
}
