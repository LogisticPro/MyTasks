using System;

namespace HomeTask_5
{
    class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());         

            ArrayHelper.OddAndEvenElemsCount(ArrayHelper.CreateIntArray(count));

            Console.ReadKey();
        }
    }
}
