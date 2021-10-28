using System;

namespace ClassLibrary
{
    public class Book
    {
        private string bookName;
        private string libraryName;
        private int allPages;

        public string BookName => bookName;

        public Book(string bookName, string libraryName, int allPages)
        {
            this.bookName = bookName;
            this.libraryName = libraryName;
            this.allPages = allPages;
        }

        public string GetInformation()
        {
            string information = (bookName +" "+ libraryName +" "+ allPages);

            return information;
        }
    }

}
