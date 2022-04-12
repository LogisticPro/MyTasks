using System;

namespace HomeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 735;

            Console.WriteLine($"{CountHelper.FirstDigit(number)} + {CountHelper.SecondDigit(number)} + {CountHelper.ThirdDigit(number)}");

            Console.WriteLine(CountHelper.FirstDigit(number) + CountHelper.SecondDigit(number) + CountHelper.ThirdDigit(number));

            Console.ReadKey();
        }
    }
}
