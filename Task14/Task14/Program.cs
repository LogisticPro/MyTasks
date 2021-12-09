using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Fleshik", 4);
            Console.WriteLine(person1.IsValid());
            Console.WriteLine();

            Person person2 = new Person("sobaken", 16);
            Console.WriteLine(person2.IsValid());
            Console.WriteLine();

            Person person3 = new Person("Someone", 18);
            Console.WriteLine(person3.IsValid());

            Console.ReadKey();
        }
    }
}
