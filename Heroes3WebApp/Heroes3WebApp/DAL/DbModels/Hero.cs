using System;
using System.Collections.Generic;

namespace DAL.DbModels
{
    public partial class Hero
    {
        public Hero()
        {
            HeroesSpells = new HashSet<HeroesSpell>();
        }

        public int Id { get; set; }
        public int TownId { get; set; }
        public int CostId { get; set; }
        public string? Name { get; set; }
        public int Type { get; set; }
        public byte[]? Picture { get; set; }

        public virtual Cost Cost { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
        public virtual ICollection<HeroesSpell> HeroesSpells { get; set; }
    }
}
