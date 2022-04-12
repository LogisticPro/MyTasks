using System;

namespace HomeTask_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[8, 14];           

            ArrayHelper.IfCovidRulesWorks(ArrayHelper.FillArrayWithOneOrTwoDigits(array));

            Console.ReadKey();
        }
    }
}
