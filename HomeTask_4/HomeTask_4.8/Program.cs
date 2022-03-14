using System;

namespace HomeTask_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            int result = 0;

            int zeroCounter = 1;

            int temp = number;

            while(number != 0)
            {
                zeroCounter *= 10;
                number /= 10;
            }

            while (zeroCounter != 0)
            {
                zeroCounter /= 10;
                result += (temp % 10) * zeroCounter;
                temp /= 10;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}                                                    