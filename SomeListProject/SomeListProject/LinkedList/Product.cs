using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using SomeListProject.DoublyLinkedList;
using SomeListProject.Stack;

namespace SomeListProject
{
    public class Product : IEquatable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public bool Equals([AllowNull] Product other)
        {
            return this.Name == other.Name && this.Price == other.Price;
        }

        public override string ToString()
        {
            return ($"Product name - {Name}, product price - {Price}");
        }
    }
}
