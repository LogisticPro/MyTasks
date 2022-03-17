using System;

namespace HomeTask_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];

            int even = 0;
            int odd = 0;

            for (int i = 1; i <= array.Length; i++)
            {
                if (i % 2 == 0) even++;
                else odd++;
            }

            Console.WriteLine($"Количество четных элементов массива - {even} \nКоличество нечетных элементов маcсива - {odd}");

            Console.ReadKey();
        }
    }
}
