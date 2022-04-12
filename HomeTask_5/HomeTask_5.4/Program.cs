using System;

namespace HomeTask_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());
           
            ArrayHelper.ReplaceFirstAndSecondHalfOfArray(ArrayHelper.ArrayRandomInitializer(ArrayHelper.CreateIntArray(count)));

            Console.ReadKey();
        }
    }
}
