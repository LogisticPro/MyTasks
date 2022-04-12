using System;

namespace HomeTask_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитать и вывести среднее арифметическое двумерного массива построчно

            int[,] array = new int[5,5];

            ArrayHelper.FindAverage(array);

            Console.ReadKey();
        }
    }
}
