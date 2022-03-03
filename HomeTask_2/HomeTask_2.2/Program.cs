using System;

namespace HomeTask_2._2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите координату выстрела х1 :");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату выстрела y1 :");
            double y1 = double.Parse(Console.ReadLine());

            double R = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            bool isHit = (R >= x1 && R >= y1);

            Console.WriteLine(isHit);
            Console.ReadKey();

        }
    }
}
