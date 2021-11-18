using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    public class Car : Vechicle
    {
        public Car(string vechicleName, int maxSpeed, int price) : base(vechicleName, maxSpeed, price)
        {
            VechicleName = vechicleName;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public override void Move()
        {
            Console.WriteLine($"{VechicleName} is mooving");
        }
    }
}
