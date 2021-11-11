using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            BluePriner bluePriner = new BluePriner();
            GreenPrinter greenPrinter = new GreenPrinter();

            Room room = new Room();

            printer.Print("Hellooooo!");
            bluePriner.Print("Hellooooo!");
            greenPrinter.Print("Hellooooo!");

            room.MakeThisLazyPrinterWork("Just print!");

            room.GetANewPrinter(greenPrinter);
            room.MakeThisLazyPrinterWork("Just print!");

            room.GetANewPrinter(bluePriner);
            room.MakeThisLazyPrinterWork("Just print!");

            Console.ReadKey();
        }
    }
}
