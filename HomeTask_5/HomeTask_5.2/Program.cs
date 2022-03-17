using System;

namespace HomeTask_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++) array[i] = rand.Next(1, 99);

            for (int i = 2; i < array.Length; i += 3) array[i] = array[i - 2] + array[i - 1];

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} \t");

            Console.ReadKey();
        }
    }
}
