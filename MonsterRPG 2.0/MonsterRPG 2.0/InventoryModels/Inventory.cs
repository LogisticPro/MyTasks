using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.InventoryModels
{
    public class Inventory
    {
        public LinkedList<Item> _items = new LinkedList<Item>();
 
        public int Size { get; private set; } = 100;
        public int CurrentSize
        {
            get
            {
                var sum = 0;

                foreach (Item item in _items)
                {
                    sum += item.Weigh;
                }
                return sum;
            }
        }
        
        public Inventory()
        {

        }
        
        public Inventory(int size)
        {
            Size = size;
        }

        public void AddItem(Item item)
        {      
            if(CurrentSize + item.Weigh <= 100)
            {
                _items.AddLast(item);
            }
            else
            {
                throw new InventoryException("Инвентарь переполнен!");
            }
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }
    }
}
