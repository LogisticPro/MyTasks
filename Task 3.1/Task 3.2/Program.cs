using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 14, y = 1, z = 5;

            for (int i = 0; i < 5; i++)
            {             
                x += y - x++ * z;
                Console.WriteLine(x);
            }
            Console.WriteLine();

            x = 14; y = 1; z = 5;

            for (int i = 0; i < 5; i++)
            {
                z = --x - y * 5;
                Console.WriteLine(z);
            }
            Console.WriteLine();

            double x = 14, y = 1, z = 5;

            for (int i = 0; i < 5; i++)
            {
                y /= x + 5 % z;
                Console.WriteLine(y);
            }
            Console.WriteLine();

            double x = 14, y = 1, z = 5;

            for (int i = 0; i < 5; i++)
            {
                z = x++ + y * 5;
                Console.WriteLine(z);
            }
            Console.WriteLine();*/

            double x = 14, y = 1, z = 5;

            for (int i = 0; i < 5; i++)
            {
                x = y - x++ *z;
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
