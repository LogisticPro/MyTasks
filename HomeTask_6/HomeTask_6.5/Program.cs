using System;

namespace HomeTask_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10, 6];

            ArrayHelper.FillArrayWithRandomDigits(array);

            Console.WriteLine();

            int[] avgAmountByMonth = new int[array.GetLength(1)];
            int[] sumAmonthByShop = new int[array.GetLength(0)];

            ArrayHelper.IncomeSum(array, sumAmonthByShop);

            Console.WriteLine();

            ArrayHelper.AverageMonthlyIncome(array, avgAmountByMonth);

            Console.ReadKey();
        }
    }
}
