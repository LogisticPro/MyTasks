using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 1, 8, 5, 16, 12, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();


            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    
                }
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
