using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_5
{
    public static class ArrayHelper
    {
        public static int[] CreateIntArray(int count)
        {
            return new int[count];
        }

        public static int[] ArrayRandomInitializer(int [] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 99);
                Console.Write($"{array[i]} ");
            }

            return array;
        }

        public static void OddAndEvenElemsCount(int [] array)
        {
            int even = 0;
            int odd = 0;

            for (int i = 1; i <= array.Length; i++)
            {
                if (i % 2 == 0) even++;
                else odd++;
            }

            Console.WriteLine($"Количество четных элементов массива - {even} \nКоличество нечетных элементов маcсива - {odd}");
        }

        public static void ReplaceEveryThirdElem(int [] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++) array[i] = rand.Next(1, 99);

            for (int i = 2; i < array.Length; i += 3) array[i] = array[i - 2] + array[i - 1];

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} \t");
        }

        public static void UnionOfTwoArrays(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++) array3[i] = array1[i];

            for (int i = 0; i < array2.Length; i++) array3[array1.Length + i] = array2[i];

            for (int i = 0; i < array3.Length; i++) Console.Write($"{array3[i]}\t");
        }

        public static void ReplaceFirstAndSecondHalfOfArray(int[] array)
        {
            int halfLength = array.Length / 2;

            for (int i = 0; i < array.Length / 2; i++, halfLength++)
            {
                int temp = array[i];

                array[i] = array[halfLength];

                array[halfLength] = temp;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
        }

        public static int[] RightCyclicalShift(int[] array)
        {
            int temp = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--) array[i] = array[i - 1];

            array[0] = temp;
            
            return array;
        }

        public static int[] OddAndEvenPositionShift(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }

            return array;
        }

        public static void MinElemAndSumAfterFirstZero(int[] array)
        {
            int minValue = int.MaxValue;

            int sum = 0;

            bool check = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minValue) minValue = Math.Abs(array[i]);

                if (check) sum += array[i];
                else if (array[i] == 0 && !check) check = true;
            }

            Console.WriteLine(minValue);
            Console.WriteLine(sum);
        }
    }
}
