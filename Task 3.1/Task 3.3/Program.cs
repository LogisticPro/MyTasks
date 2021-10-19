using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колиство вводных чисел...");

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Введите {0} чисел (числа)...", n);

            int maxIndex = FindMaxIndex(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                for (int counter = FindMaxIndex(array); counter >= 0; counter--)
                {

                } 
            }



            Console.ReadKey();
        }
        static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
