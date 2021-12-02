using System;
using System.Collections.Generic;
using System.Text;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("milk", "Sosedi");
            var product2 = new Product("bred", "Vitalur");
            var product3 = new Product("eggs", "Vitalur");
            var product4 = new Product("chicken", "Sosedi");
            var product5 = new Product("shavuha", "PapaDoner");

            Product[] products = new Product[5] { product1, product2, product3, product4, product5 };

            Array.Sort(products);

            List<string> list = new List<string>();

            Console.WriteLine("Введите название магазина..");
            var name = Console.ReadLine();

            foreach(var item in products)
            {
                if (item.ShopName == name)
                {
                    list.Add(item.Name);
                }               
            }
  
            if (list.Count > 0)
            {
                foreach (var item in list)
                    Console.WriteLine(item);
            }
            else
            {
                throw new CustomExeption($"магазина с названием {name} не существует");
            }

            Console.ReadKey();
        }
    }
}
