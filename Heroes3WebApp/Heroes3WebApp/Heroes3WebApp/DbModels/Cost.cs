using System;
using System.Collections.Generic;

namespace Heroes3WebApp.DbModels
{
    public partial class Cost
    {
        public Cost()
        {
            Buildings = new HashSet<Building>();
            Heroes = new HashSet<Hero>();
            Monsters = new HashSet<Monster>();
        }

        public int Id { get; set; }
        public int Gold { get; set; }
        public int? Ore { get; set; }
        public int? Wood { get; set; }
        public int? Gem { get; set; }
        public int? Crystal { get; set; }
        public int? Mercury { get; set; }
        public int? Sulfyr { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Hero> Heroes { get; set; }
        public virtual ICollection<Monster> Monsters { get; set; }
    }
}
