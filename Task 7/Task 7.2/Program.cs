using System;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayX2 = new int[3, 3]
            {
                { 6, 15, 8 },
                { 7, 54, 59 },
                { 17, 81, 94 },
            };

            for (int i = 0; i < arrayX2.GetLength(0); i++)
            {
                Console.WriteLine(GetMaxNuber(arrayX2, i));
            }

            Console.ReadKey();

        }

        static int GetMaxNuber(int[,] array, int row)
        {
            int maxValue = array[row, 0];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (maxValue < array[row, i])
                {
                    maxValue = array[row, i];
                }
            }
            return maxValue;
        }
    }
}

