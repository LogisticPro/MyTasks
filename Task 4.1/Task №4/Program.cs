using System;

namespace Task__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число..");

            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 30)
            
                Console.WriteLine("Число {0} находится в 1-ом проемжутке", number);

            else if (number >= 31 && number <= 60)

                Console.WriteLine("Число {0} находится в 2-ом промежутке", number);

            else if (number >= 61 && number <= 100)

                Console.WriteLine("Число {0} находится в 2-ом промежутке", number);

            else

                Console.WriteLine("Я такого числа не знаю");

            Console.ReadLine();
        }
    }
}
