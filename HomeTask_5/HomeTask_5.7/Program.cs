using System;

namespace HomeTask_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-5, 5);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            int minValue = int.MaxValue;

            int sum = 0;

            bool check = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minValue) minValue = Math.Abs(array[i]);

                if(check) sum += array[i];

                if (array[i] == 0 && !check) check = true;

            }

            Console.WriteLine(minValue);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
