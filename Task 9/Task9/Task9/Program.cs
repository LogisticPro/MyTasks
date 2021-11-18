using System;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat("Locman", 75, 7000);
            Boat superBoat = new Boat("Poseidon", 150, 14000);

            Car car = new Car("Opel", 100, 10000);
            Car superCar = new Car("Jaguar", 200, 20000);

            var collection = new MyCollection<Vechicle>();

            collection.Add(boat);
            collection.Add(superBoat);
            collection.Add(car);
            collection.Add(superCar);

            Console.WriteLine($"Elements value: {collection.Count}");           
            Console.WriteLine();

            collection.GetValue(1);
            Console.WriteLine();

            superBoat.Move();

            Console.ReadKey();
        }
    }
}
