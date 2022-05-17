using System;
using SomeListProject.DoublyLinkedList;
using SomeListProject.Stack;
using SomeListProject.Queue;
using SomeListProject.List;

namespace SomeListProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //LinkedList<Product> list = new LinkedList<Product>();

            //list.AddFirst(new Product("Milk", 3));
            //list.AddLast(new Product("Bread", 2));
            //list.AddFirst(new Product("Butter", 5));
            //list.AddLast(new Product("Sourcream", 4));

            //foreach(Product prod in list)
            //{
            //    Console.WriteLine($"Название - {prod.Name}, стоимость - {prod.Price} рублёу");
            //}

            //Console.WriteLine();

            //try
            //{
            //    list.Remove(new Product("Bread", 2));
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine();

            //foreach (Product prod in list)
            //{
            //    Console.WriteLine($"Название - {prod.Name}, стоимость - {prod.Price} рублёу");
            //}

            //Console.WriteLine("-----------------------------------------------------------------");

            //Stack<Product> stack = new Stack<Product>();

            //stack.Push(new Product("Milk", 3));
            //stack.Push(new Product("Bread", 2));
            //stack.Push(new Product("Butter", 5));
            //stack.Push(new Product("Sourcream", 4));

            //Console.WriteLine(stack.Pop().ToString());
            //Console.WriteLine(stack.Pop().ToString());
            //Console.WriteLine(stack.Pop().ToString());
            //Console.WriteLine(stack.Pop().ToString());
            //Console.WriteLine(stack.Pop().ToString());

            //Console.WriteLine("-----------------------------------------------------------------");

            //Queue<Product> queue = new Queue<Product>();

            //queue.Push(new Product("Milk", 3));
            //queue.Push(new Product("Bread", 2));
            //queue.Push(new Product("Butter", 5));
            //queue.Push(new Product("Sourcream", 4));

            //Console.WriteLine(queue.Pop().ToString());

            //Console.WriteLine("-----------------------------------------------------------------");

            var products = new CustomList<Product>();

            var product1 = new Product("Milk", 3);
            var product2 = new Product("Bread", 2);
            var product3 = new Product("Butter", 5);
            var product4 = new Product("Sourcream", 4);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            foreach(var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            products.RemoveAt(2);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            products.Remove(product1);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
        }
    }
}
