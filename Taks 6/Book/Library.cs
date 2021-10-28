using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        private Book[] books;
   
        public Library(Book[] books)
        {
            this.books = books;
        }      
        
        public void GetInformationFromIndex(int index)
        {
            Console.WriteLine (books[index].GetInformation());
        }

        public string GetInforationOfBook(string name)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (name == books[i].BookName)
                {
                    return books[i].GetInformation();
                }
            }

            return "Такой книги нет";
        }

    }
}
