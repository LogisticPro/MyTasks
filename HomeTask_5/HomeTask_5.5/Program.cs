using System;

namespace HomeTask_5._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] {1, 2, 3, 4, 5 };

            int temp = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--) array[i] = array[i - 1];       

            array[0] = temp;

            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);

            Console.ReadKey();
        }
    }
}
