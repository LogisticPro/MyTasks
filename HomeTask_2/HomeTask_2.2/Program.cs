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

            bool isHit = (CountHelper.RadiusFounder(x1, y1) >= x1 && CountHelper.RadiusFounder(x1, y1) >= y1);

            Console.WriteLine(isHit);
            Console.ReadKey();

        }
    }
}
