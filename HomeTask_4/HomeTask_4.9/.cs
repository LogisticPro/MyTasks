using System;

namespace HomeTask_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int number = int.Parse(Console.ReadLine());

            MathHelper.IfSameDigitsExists(number);

            Console.ReadKey();
        }
    }
}
                