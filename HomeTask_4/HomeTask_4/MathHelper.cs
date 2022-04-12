using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_4
{
    public static class MathHelper
    {
        public static void DivisionByA(int number)
        {
            for (int i = 1; i <= 1000;i++)
            {
                if (i % number == 0) Console.WriteLine(i);
            }
        }

        public static void FindSquareNumbersLessThanA(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (Math.Pow(i, 2) < number) Console.WriteLine(i);
            }
        }

        public static void GreatestCommonDivisor(int number)
        {
            int temp = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    temp = i;
            }

            Console.WriteLine(temp);
        }

        public static void CompareAandB(int a, int b)
        {
            while (b < a)
            {
                Console.WriteLine("Второе число должно быть больше первого, повторите ввод!");

                Console.WriteLine("Введите первое число:");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = int.Parse(Console.ReadLine());
            }
        }

        public static void SumFromAtoBdividedBy7(int a, int b)
        {
            int temp = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                    temp += i;
            }

            Console.WriteLine(temp);
        }

        public static void EvklidsGreatestDivisior(int a, int b)
        {
            int temp1 = 0;
            int temp2 = 0;

            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    temp1 = a % b;

                    temp2 = b % temp1;

                    if (b % temp1 == 0) Console.WriteLine($"Нод равен {temp1}");
                    else if (temp1 % temp2 == 0) Console.WriteLine($"Нод равен {temp2}");
                    else if (temp1 % temp2 != 0) Console.WriteLine($"Нод равен {temp1 % temp2}");
                    else Console.WriteLine("Нод равен 1");
                }
            }
            else if (b > a)
            {
                if (b % a == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    temp1 = b % a;
                    temp2 = a % temp1;

                    if (a % temp1 == 0) Console.WriteLine($"Нод равен {temp1}");
                    else if (temp1 % temp2 == 0) Console.WriteLine($"Нод равен {temp2}");
                    else if (temp1 % temp2 != 0) Console.WriteLine($"Нод равен {temp1 % temp2}");
                    else Console.WriteLine("Нод равен 1");
                }
            }
            else Console.WriteLine($"Нод равен {a}");
        }

        public static void OddNumbersCount(int number)
        {
            int counter = 0;

            while (number != 0)
            {
                if ((number % 10) % 2 != 0) counter++;

                number = number / 10;
            }

            Console.WriteLine($"Количество нечетных цифр в числе равно {counter}");
        }

        public static void NumbersMirrorImage(int number)
        {
            int result = 0;

            int zeroCounter = 1;

            int temp = number;

            while (number != 0)
            {
                zeroCounter *= 10;
                number /= 10;
            }

            while (zeroCounter != 0)
            {
                zeroCounter /= 10;
                result += (temp % 10) * zeroCounter;
                temp /= 10;
            }

            Console.WriteLine(result);
        }

        public static void IfSameDigitsExists(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            int temp = 0;
            int iterator = 0;

            for (int i = 1; i <= number; i++)
            {
                iterator = i;

                while (i != 0)
                {
                    temp = i % 10;

                    if (temp % 2 == 0)
                    {
                        evenSum += temp;
                    }
                    else
                    {
                        oddSum += temp;
                    }

                    i /= 10;
                }

                if (evenSum > oddSum) Console.WriteLine(iterator);

                evenSum = 0;

                oddSum = 0;

                i = iterator;
            }
        }
    }
}
