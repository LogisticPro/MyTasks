using System;
using System.Collections.Generic;
using System.Text;

namespace Task13
{
    class CustomExeption : Exception
    {
        public CustomExeption()
        {
                
        }

        public CustomExeption(string message)
        {
            Console.WriteLine(message);
        }
    }
}
