using System;

namespace HomeTask_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int number = int.Parse(Console.ReadLine());

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

            Console.ReadKey();
        }
    }
}
                