using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");

            string radius = Console.ReadLine();
            double r;

            while (Double.TryParse(radius, out r))
            {              
                Console.WriteLine("Вы ввели неверное значение, повторите");
                radius = Console.ReadLine();
            }

            Console.WriteLine("Введите значение образующей");

            string generatrix = Console.ReadLine();
            double l;

            while (!Double.TryParse(generatrix, out l))
            {
                Console.WriteLine("Вы ввели неверное значение, повторите");
                generatrix = Console.ReadLine();
            }

            double s = Math.PI * r * (r + l);

            Console.WriteLine("Площадь круглого конуса равна: {0}", s);

            Console.ReadKey();
        }
    }
}
