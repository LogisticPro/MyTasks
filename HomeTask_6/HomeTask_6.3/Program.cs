using System;

namespace HomeTask_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[8, 8];

            ArrayHelper.FillChessTable(array);

            Console.ReadKey();
        }
    }
}
