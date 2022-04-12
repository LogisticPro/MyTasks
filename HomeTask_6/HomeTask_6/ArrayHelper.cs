using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_6
{
    public static class ArrayHelper
    {
        public static void ChangeSideSign(int [,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 10);
                    if (i == 0 || j == 0 || i == array.GetLength(0) - 1 || j == array.GetLength(1) - 1) Console.Write($"\t{-array[i, j]}");
                    else Console.Write($"\t {array[i, j]}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void MultiplicationTable(int[,] array)
        {
            for (int i = 1; i < array.GetLength(0) + 1; i++)
            {
                for (int j = 1; j < array.GetLength(1) + 1; j++)
                {
                    Console.Write($"\t {j * i}");
                }
                Console.WriteLine("\n");
            }
        }

        public static void FillChessTable(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((j + i) % 2 == 0) Console.Write($"\t 1");
                    else Console.Write($"\t 0");
                }
                Console.WriteLine("\n");
            }
        }

        public static int[,] FillArrayWithOneOrTwoDigits(int [,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 2);
                }
            }

            return array;
        }

        public static void IfCovidRulesWorks(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] == 1 && array[i, j + 1] == 1)
                    {
                        Console.WriteLine($"В ряду номер {i + 1} ковидные ограничения НЕ соблюдаются!");
                        break;
                    }
                }
            }
        }

        public static int[,] FillArrayWithRandomDigits(int[,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100, 200);
                    Console.Write($"\t{array[i, j]}");
                }
                Console.WriteLine("\n");
            }

            return array;
        }

        public static void IncomeSum(int[,] array, int[] sumAmonthByShop)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumAmonthByShop[i] += array[i, j];
                }
                Console.WriteLine($"Cуммарный доход магазина №{i + 1} составил {sumAmonthByShop[i]} рублей");
            }
        }

        public static void AverageMonthlyIncome(int[,] array, int[] avgAmountByMonth)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    avgAmountByMonth[j] += array[i, j];
                }
                avgAmountByMonth[j] /= 10;

                Console.WriteLine($"Cредний доход магазинов за месяц №{j + 1} составил {avgAmountByMonth[j]} рублей");
            }
        }
    }
}
