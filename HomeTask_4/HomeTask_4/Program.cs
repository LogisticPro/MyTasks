using System;

namespace HomeTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            while(number > 1000 && number < -1000)
            {
                Console.WriteLine("Неподходящее для деления число, повторите ввод:");
                number = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 1000; i++)
            {
                if(i % number == 0) Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
