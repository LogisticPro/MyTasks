using System;
using ClassLibrary;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Book[] array = new Book[3];
            array[0] = new Book("RussianLanguage", "Library№1", 100);
            array[1] = new Book("Mathematics", "Library№2", 150);
            array[2] = new Book("Physics", "Library№3", 200);

            Library l = new Library(array);

            Console.WriteLine("Введите номер индекса книги (от 0 до 2), чтобы узнать информацию о ней");
            int str1 = int.Parse(Console.ReadLine());
            l.GetInformationFromIndex(str1);

            Console.WriteLine("Какую книгу вам предоджить");
            string name = Console.ReadLine();
            Console.WriteLine(l.GetInforationOfBook(name));

            Console.ReadKey();
        }
    }
}
