using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    public class Vechicle
    {
        protected string VechicleName { get; set; }
        protected int MaxSpeed { get; set; }
        protected int Price { get; set; }

        public Vechicle(string vechicleName, int maxSpeed, int price)
        {
            VechicleName = vechicleName;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public virtual void Move()
        {
            Console.WriteLine("Vechicle is mooving");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Vechicle name : {VechicleName}");
            Console.WriteLine($"Max speed : {MaxSpeed}");
            Console.WriteLine($"The price is : {Price}$");
        }
    }
}
