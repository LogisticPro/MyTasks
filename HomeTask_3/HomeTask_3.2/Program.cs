using System;

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

            if(X > 0 && Y > 0) Console.WriteLine("Точка принадлежит 1-ой четверти координатной плоскости");
               else if(X > 0 && Y <= 0) Console.WriteLine("Точка принадлежит 2-ой четверти координатной плоскости");
                  else if(X < 0 && Y < 0) Console.WriteLine("Точка принадлежит 3-ой четверти координатной плоскости");
                     else Console.WriteLine("Точка принадлежит 4-ой четверти координатной плоскости");

            Console.ReadKey();
        }
    }
}
