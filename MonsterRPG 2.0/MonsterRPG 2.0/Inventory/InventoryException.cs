using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Inventory
{
    internal class InventoryException : Exception
    {
        public InventoryException(string message) : base(message)
        {

        }
    }
}
