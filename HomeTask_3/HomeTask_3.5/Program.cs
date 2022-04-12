using System;

namespace HomeTask_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число :");

            int number = int.Parse(Console.ReadLine());

            string str1 = Convert.ToString(number % 10);

            string str2 = null;

            IntToStringNumber.IntToStr(str1, str2);

            Console.ReadKey();
        }
    }
}
