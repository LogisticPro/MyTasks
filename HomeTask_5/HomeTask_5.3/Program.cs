using System;

namespace HomeTask_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };

            int[] array2 = new int[] { 6, 7, 8, 9, 10 };

            int[] array3 = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++) array3[i] = array1[i];

            for (int i = 0; i < array2.Length; i++) array3[array1.Length + i] = array2[i];

            for (int i = 0; i < array3.Length; i++) Console.Write($"{array3[i]}\t");

            Console.ReadKey();
        }
    }
}
