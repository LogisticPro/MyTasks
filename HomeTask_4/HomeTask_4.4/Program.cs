using System;

namespace HomeTask_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            while(b < a)
            {
                Console.WriteLine("Второе число должно быть больше первого, повторите ввод!");

                Console.WriteLine("Введите первое число:");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                 b = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for(int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                    temp += i;
            }

            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
