using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task13
{
    public struct Product : IComparable<Product>
    {       
        public string Name { get; set; }
        public string ShopName { get; set; }
        public Product(string name, string shopName)
        {
            Name = name;
            ShopName = shopName;
        }

        public int CompareTo(Product product)
        {
            return ShopName.CompareTo(product.ShopName);
        }
    }
}
