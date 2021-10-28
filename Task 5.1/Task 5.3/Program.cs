using System;

namespace Cone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус основания");
            double radius2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту конуса");
            double height2 = Double.Parse(Console.ReadLine());

            Cone cone = new Cone(radius2, height2);

            Console.WriteLine("Площадь основания конуса равна");
            double baseSquare = cone.FindBaseSquare();
            Console.WriteLine(baseSquare);

            Console.WriteLine("Общая площадь конуса равна");
            double fullSquare = cone.FindFullSquare();
            Console.WriteLine(fullSquare);

            Console.ReadLine();
        }
    }
}
