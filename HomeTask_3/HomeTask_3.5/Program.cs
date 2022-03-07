using System;

namespace HomeTask_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число :");

            int number = int.Parse(Console.ReadLine());

            string str1 = Convert.ToString(number % 10);

            string str2 = null;

            if (str1 == "1")
                str2 = "один";
            else if (str1 == "2")
                str2 = "два";
            else if (str1 == "3")
                str2 = "три";
            else if (str1 == "4")
                str2 = "четыре";
            else if (str1 == "5")
                str2 = "пять";
            else if (str1 == "6")
                str2 = "шесть";
            else if (str1 == "7")
                str2 = "семь";
            else if (str1 == "8")
                str2 = "восемь";
            else if (str1 == "9")
                str2 = "девять";
            else
                str2 = "";

            if (number == 10)
                Console.WriteLine("Десять");
            else if(number == 11)
                Console.WriteLine("Одинадцать");
            else if (number == 12)
                Console.WriteLine("Двенадцать");
            else if (number == 13)
                Console.WriteLine("Тринадцать");
            else if (number == 14)
                Console.WriteLine("Четырнадцать");
            else if (number == 15)
                Console.WriteLine("Пятнадцать");
            else if (number == 16)
                Console.WriteLine("Шеснадцать");
            else if (number == 17)
                Console.WriteLine("Семнадцать");
            else if (number == 18)
                Console.WriteLine("Восемнадцать");
            else if (number == 19)
                Console.WriteLine("Девятнадцать");
            else if (number >= 20 && number < 30)
                Console.WriteLine($"Двадцать {str2}");
            else if (number >= 30 && number < 40)
                Console.WriteLine($"Тридцать {str2}");
            else if (number >= 40 && number < 50)
                Console.WriteLine($"Сорок {str2}");
            else if (number >= 50 && number < 60)
                Console.WriteLine($"Пятьдесят {str2}");
            else if (number >= 60 && number < 70)
                Console.WriteLine($"Шестьдесят {str2}");
            else if (number >= 70 && number < 80)
                Console.WriteLine($"Семдесят {str2}");
            else if (number >= 80 && number < 90)
                Console.WriteLine($"Восемдесят {str2}");
            else if (number >= 90 && number < 100)
                Console.WriteLine($"Девяносто {str2}");

            Console.ReadKey();
        }
    }
}
