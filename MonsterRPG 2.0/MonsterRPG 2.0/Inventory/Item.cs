using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Inventory
{
    internal class Item
    {
        public string Name { get; private set; }
        public InventoryItemType Type { get; private set; }
        public int Price { get; private set; }
        public int Weigh { get; private set; }

        public Item(InventoryItemType type, string name, int price, int weigh)
        {
            Name = name;
            Type = type;
            Price = price;
            Weigh = weigh;
        }
    }
}
