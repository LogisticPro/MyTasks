using System;

namespace HomeTask_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {9, 88, 79, 4, 17, 36, 51, 22};

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

            Console.ReadKey();
        }
    }
}
