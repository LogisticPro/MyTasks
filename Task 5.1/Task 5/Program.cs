using System;

namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWorker inversion = new ArrayWorker();

            Console.WriteLine("Введите количеесво элементов в массиве");
            string number = Console.ReadLine();

            int elementsNumber;

            while (!int.TryParse(number, out elementsNumber))
            {
                Console.WriteLine("Введите корректное число!");
                number = Console.ReadLine();
            }

            int [] array = new int[elementsNumber];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите значение {0} элемента массива", i);

                string number2 = Console.ReadLine();

                while (!int.TryParse(number2, out array[i]))
                {
                    Console.WriteLine("Введите корректное число!");
                    number2 = Console.ReadLine();
                }
            }

            var array2 = inversion.Invert(array);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.ReadKey();
        }
    }
}
