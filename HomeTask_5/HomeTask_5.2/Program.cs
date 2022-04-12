using System;

namespace HomeTask_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());

            ArrayHelper.ReplaceEveryThirdElem(ArrayHelper.CreateIntArray(count));

            Console.ReadKey();
        }
    }
}
