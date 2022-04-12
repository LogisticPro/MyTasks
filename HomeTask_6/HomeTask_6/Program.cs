using System;

namespace HomeTask_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 8];

            ArrayHelper.ChangeSideSign(array);

            Console.ReadLine();
        }
    }
}
