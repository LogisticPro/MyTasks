using System;

namespace HomeTask_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите double число..");
            double doubleNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(CountHelper.IsZeroFractionalPart(doubleNumber));
            Console.ReadKey();
        }
    }
}
