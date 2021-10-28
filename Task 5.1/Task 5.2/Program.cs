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

            int[] source = new  int[elementsNumber];

            for (int i = 0; i < source.Length; i++)
            {
                Console.WriteLine("Введите значение {0} элемента массива", i);

                string number2 = Console.ReadLine();

                while (!int.TryParse(number2, out source[i]))
                {
                    Console.WriteLine("Введите корректное число!");
                    number2 = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите индекс нового элемента массива");
            int index = int.Parse(Console.ReadLine());

            while (index > elementsNumber)
            {
                Console.WriteLine("Ваш новый индекс не может быт больше {0}", elementsNumber);

                Console.WriteLine("Введите индекс нового элемента массива");

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите значение нового элмента массива");
            int newValue = int.Parse(Console.ReadLine());

            var array2 = inversion.Invert(source, index, newValue);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.ReadKey();
        }
    }
}