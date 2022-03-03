using System;

namespace HomeTask_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитать и вывести среднее арифметическое двумерного массива построчно

            int[,] array = new int[5,5];

            Random rand = new Random();

            int sred = 0;

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {              
                for (int j = 0; j < 5; j++)
                {
                    array[i,j] = rand.Next(50);

                    Console.Write("{0}\t", array[i, j]);

                    sum += array[i,j];                
                }
                sred = sum / 5;                

                Console.WriteLine($"Среднее арифметическое строки № {i + 1} = {sred}");

                sum = 0;
            }
            Console.ReadKey();
        }
    }
}
