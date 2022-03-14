using System;

namespace HomeTask_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            int temp1 = 0;
            int temp2 = 0;

            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    temp1 = a % b;

                    temp2 = b % temp1;

                    if (b % temp1 == 0) Console.WriteLine($"Нод равен {temp1}");                  
                    else if (temp1 % temp2 == 0) Console.WriteLine($"Нод равен {temp2}");
                    else if (temp1 % temp2 != 0) Console.WriteLine($"Нод равен {temp1 % temp2}");
                    else Console.WriteLine("Нод равен 1");
                }
            }
            else if (b > a)
            {
                if (b % a == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    temp1 = b % a;
                    temp2 = a % temp1;

                    if (a % temp1 == 0) Console.WriteLine($"Нод равен {temp1}");
                    else if (temp1 % temp2 == 0) Console.WriteLine($"Нод равен {temp2}");
                    else if (temp1 % temp2 != 0) Console.WriteLine($"Нод равен {temp1 % temp2}");
                    else Console.WriteLine("Нод равен 1");
                }
            }
            else Console.WriteLine($"Нод равен {a}");

            Console.ReadKey();
        }
    }
}
