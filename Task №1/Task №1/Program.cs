using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {       
            Random rand = new Random();

            int nails = rand.Next(1, 11);

            for (int i = 1; i <= nails; i++)
            {
                Console.WriteLine("Забиваю " + i + " гвоздь:");
                hammerInANail();
            }

            Console.WriteLine("Все гвозди в количестве " + nails + " штук забиты!");
            Console.ReadKey();
        }
        static int hammerInANail()
        {
            Random rand = new Random();

            int hitANail = rand.Next(1, 6);

            for (int i = 1; i <= hitANail; i++)
            {
                if (i < hitANail)
                    Console.WriteLine("Гвоздь не забит, произвожу ещё один удар");
                else
                    Console.WriteLine("Гвоздь забит c " + hitANail + " удара");
            }
            Console.WriteLine();

            return hitANail;
        }

    }
}
