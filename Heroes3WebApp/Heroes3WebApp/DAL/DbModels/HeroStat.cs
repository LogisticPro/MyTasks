using System;
using System.Collections.Generic;

namespace DAL.DbModels
{
    public partial class HeroStat
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public int HeroType { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Spellpower { get; set; }
        public int Knowledge { get; set; }

        public virtual Town Town { get; set; } = null!;
    }
}
