using System;

namespace HomeTask_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            MathHelper.NumbersMirrorImage(number);  

            Console.ReadKey();
        }
    }
}                                                    