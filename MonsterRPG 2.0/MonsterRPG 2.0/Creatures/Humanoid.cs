using System;
using System.Collections.Generic;
using System.Text;
using MonsterRPG_2._0.InventoryModels;
using MonsterRPG_2._0.Monsters;

namespace MonsterRPG_2._0.Creatures
{
    public abstract class Humanoid : Creature
    {
        protected Inventory inventar = new Inventory();
        public CreatureTypeEnum CreatureType => CreatureTypeEnum.Humanoid;
        public RacesEnum Race { get; }
        public int Intelligence { get; protected set; }
        public int Agility { get; protected set; }
        public int Strength { get; protected set; }

        public Humanoid(RacesEnum race, string name)
        {          
            Race = race;
            Name = name;
        }
    }
}
