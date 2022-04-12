using System;

namespace HomeTask_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {9, 88, 79, 4, 17, 36, 51, 22};

            ArrayHelper.OddAndEvenPositionShift(array);

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

            Console.ReadKey();
        }
    }
}
