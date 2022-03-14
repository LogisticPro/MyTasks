using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            int temp1 = 0;
            int temp2 = 0;

             List<int> list1 = new List<int>();

            while (a != 0)
            {
                temp1 = a % 10;

                list1.Add(temp1);

                a /= 10;
            }

            while (b != 0)
            {
                temp2 = b % 10;

                list1.Add(temp2);

                b /= 10;
            }

            int i = 0;

            int j = 0;

            for (i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i] + " ");
            }

            List<int> list2 = list1.Distinct().ToList();
            Console.WriteLine();

            for (j = 0; j < list2.Count; j++)
            {
                Console.Write(list2[j] + " ");
            }

            Console.WriteLine();

            if (i > j) Console.WriteLine("Да!");
            else if (i == j) Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}    