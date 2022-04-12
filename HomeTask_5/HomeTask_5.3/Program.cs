using System;

namespace HomeTask_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };

            int[] array2 = new int[] { 6, 7, 8, 9, 10 };

            ArrayHelper.UnionOfTwoArrays(array1, array2);

            Console.ReadKey();
        }
    }
}
