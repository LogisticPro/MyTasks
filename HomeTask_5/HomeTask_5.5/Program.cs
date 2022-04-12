using System;

namespace HomeTask_5._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] {1, 2, 3, 4, 5 };

            ArrayHelper.RightCyclicalShift(array);

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");

            Console.ReadKey();
        }
    }
}
