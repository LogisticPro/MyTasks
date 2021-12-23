using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Stopwatch stopWatch = new Stopwatch();

            TimeSpan ts = stopWatch.Elapsed;

            for (int i = 1; i < 100000; i++)
            {
                Car car = new Car(i);
                cars.Add(car);
            }

            stopWatch.Start();
            foreach (Car car in cars)
            {
                car.age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute;
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime " + ts);

            Console.WriteLine("*******************************");

            stopWatch.Start();
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute;
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime " + ts);

            Console.WriteLine("*******************************");

            stopWatch.Start();
            Parallel.ForEach(cars, car => car.age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime " + ts);

            Console.WriteLine("*******************************");


            Action<int> carsDel = (int i) => { cars[i].age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute; };


            stopWatch.Start();
            Parallel.For(0, cars.Count, carsDel);
            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime " + ts);

            Console.ReadKey();
        }
    }
}
