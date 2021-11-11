using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8
{
    public class Room
    {
        Printer printer = new Printer();

        public void MakeThisLazyPrinterWork(string value)
        {
            printer.Print(value);       
        }

        public void GetANewPrinter(Printer printer)
        {
            this.printer = printer;
        }
    }
}
