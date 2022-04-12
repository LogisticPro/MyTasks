using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7
{
    public static class IOHelper
    {
        public static int SaveInput(int min_value, int max_value, string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());

            while (number < min_value && number > max_value)
            {
                Console.WriteLine(message);
                Console.WriteLine($"Введите целое число в диапазоне от {min_value} до {max_value}");
                number = int.Parse(Console.ReadLine());
            }
            return number;
        }

        public static double SaveInput(double min_value, double max_value, string message)
        {
            Console.WriteLine(message);
            double number = double.Parse(Console.ReadLine());

            while (number < min_value && number > max_value)
            {
                Console.WriteLine(message);
                number = int.Parse(Console.ReadLine());
            }
            return number;
        }

        public static (double, double) InputPoint(string message)
        {
            Console.WriteLine(message);
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            return (number1, number2);
        }

        public static void Line(int length)
        {
            string str = "";

            for (int i = 0; i < length; i++)
            {
                str += '-';
            }

            Console.WriteLine(str);
        }

        public static int TextMenu(string[] menu_items)
        {
            for (int i = 1; i < menu_items.Length + 1; i++)
            {
                Console.WriteLine($"{i} - {menu_items[i - 1]}");
            }

            Console.WriteLine("Выберите пункт меню:");

            int j = 1;

            for (j = 1; j < menu_items.Length + 1; j++)
            {
                string str = Console.ReadLine();
                while (str != menu_items[j])
                {
                    Console.WriteLine("Такого пункта в меню нет, повторите ввод");
                    str = Console.ReadLine();
                }
            }
            Console.WriteLine("Вы выбрали пункт под номером ");
            return j;
        }

        public static int[] GenerateIntArray(int size, int min, int max)
        {
            int[] array = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max);
            }

            return array;
        }

        public static double[] GenerateDoubleArray(int size, double min, double max)
        {
            double[] array = new double[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.NextDouble() * (max - min) + min;
            }

            return array;
        }

        public static int[,] GenerateIntMatrix(int rows, int cols, int min, int max)
        {
            int[,] array = new int[rows, cols];

            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(min, max);
                }
            }

            return array;
        }

        public static double[,] GenerateDoubleMatrix(int rows, int cols, double min, double max)
        {
            double[,] array = new double[rows, cols];

            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.NextDouble() * (max - min) + min;
                }
            }

            return array;
        }

        public static void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
        }
        public static void PrintArray(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintArray(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}\t");
            }
        }
        public static void PrintArray(double[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
