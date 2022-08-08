using System;
using System.Collections.Generic;

namespace Heroes3WebApp.DbModels
{
    public partial class Spell
    {
        public Spell()
        {
            HeroesSpells = new HashSet<HeroesSpell>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public byte[]? Picture { get; set; }
        public int Level { get; set; }

        public virtual ICollection<HeroesSpell> HeroesSpells { get; set; }
    }
}
