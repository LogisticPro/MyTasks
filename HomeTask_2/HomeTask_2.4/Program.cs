using System;

namespace HomeTask_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое трёхзначно число..");
            int number = int.Parse(Console.ReadLine());

            int firstNumber = number / 100;

            int secondNumber = (number % 100) / 10;

            int thirdNumber = number % 10;

            string temp = (Convert.ToString(thirdNumber) + Convert.ToString(secondNumber) + Convert.ToString(firstNumber));

            int result = Convert.ToInt32(temp);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
