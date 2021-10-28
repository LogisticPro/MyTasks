using System;

namespace ClassLibrary
{
    public class ArrayWorker
    {
        public int [] Invert (int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int value = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = value;
            }
            return array;
        }

        public int[] Invert(int[] source, int index, int newValue)
        {
            var array2 = new int[source.Length + 1];

            array2[index] = newValue;

            for (int i = 0; i < index; i++)
            {
                array2[i] = source[i];
            }

            for (int i = index; i < source.Length; i++)
            {
                array2[i + 1] = source[i];
            }


            return array2;
        }
    }
}
