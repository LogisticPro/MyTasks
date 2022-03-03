using System;

namespace HomeTask_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите double число..");
            double doubleNumber = double.Parse(Console.ReadLine());

            int intNumber = (int)doubleNumber;

            bool IsZeroFractionalPart = intNumber == doubleNumber;

            Console.WriteLine(IsZeroFractionalPart);
            Console.ReadKey();
        }
    }
}
