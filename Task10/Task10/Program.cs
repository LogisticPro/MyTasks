using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyItem item1 = new MyItem(4);
            MyItem item2 = new MyItem(5);
            MyItem item3 = new MyItem(6);

            MyList list1 = new MyList();

            list1.Add(item1);
            list1.Add(item2);

            list1.Insert(0, item3);

            list1.Remove(item1);

            foreach(var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list1.IndexOf(item2));

            Console.ReadKey();
        }
    }
}
