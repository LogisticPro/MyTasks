using System;

namespace HomeTask_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначно число..");
            int number = int.Parse(Console.ReadLine());

            bool result = CountHelper.FirstDigit(number) >= CountHelper.SecondDigit(number) && 
                CountHelper.SecondDigit(number) > CountHelper.ThirdDigit(number);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
