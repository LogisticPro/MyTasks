using System;
using System.Collections.Generic;
using System.Text;

namespace Task10
{
    class MyItem
    {
        private int Item { get; set; }
        public MyItem(int item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}
