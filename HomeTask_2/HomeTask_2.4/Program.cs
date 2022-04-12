using System;

namespace HomeTask_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое трёхзначно число..");
            int number = int.Parse(Console.ReadLine());

            string temp = (Convert.ToString(CountHelper.ThirdDigit(number)) + Convert.ToString(CountHelper.SecondDigit(number)) + 
                Convert.ToString(CountHelper.FirstDigit(number)));

            int result = Convert.ToInt32(temp);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
