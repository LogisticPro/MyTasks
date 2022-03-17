using System;

namespace HomeTask_5._4
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
                array[i] = rand.Next(1, 99);
                Console.Write($"{array[i]} ");
            }

            int halfLength = array.Length / 2;

            for (int i = 0; i < array.Length / 2; i++, halfLength++)
            {
                int temp = array[i];

                array[i] = array[halfLength];

                array[halfLength] = temp;             
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

            Console.ReadKey();
        }
    }
}
