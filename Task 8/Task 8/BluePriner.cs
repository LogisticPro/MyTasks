using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8
{
    public class BluePriner : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
