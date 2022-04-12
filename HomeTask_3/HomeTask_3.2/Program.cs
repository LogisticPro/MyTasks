using System;
using System.Collections.Generic;
using System.Text;
using HomeTask_3;

namespace HomeTask_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число :");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число :");
            int Y = int.Parse(Console.ReadLine());

            CompareHelper.CompareXY(X, Y);           

            Console.ReadKey();
        }
    }
}
