using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_1
{
    public static class ArrayHelper
    {
        public static int RandomNumer()
        {
            Random rand = new Random();

            return rand.Next(50);
        }

        public static void FindAverage(int[,] array)
        {
            int sred = 0;

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = RandomNumer();

                    Console.Write("{0}\t", array[i, j]);

                    sum += array[i, j];
                }
                sred = sum / 5;

                Console.WriteLine($"Среднее арифметическое строки № {i + 1} = {sred}");

                sum = 0;
            }
        }
    }
}
