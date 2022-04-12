using System;

namespace HomeTask_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[9, 9];

            ArrayHelper.MultiplicationTable(array);

            Console.ReadKey();
        }
    }
}
