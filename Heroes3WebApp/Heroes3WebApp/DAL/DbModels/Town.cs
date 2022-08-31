using System;
using System.Collections.Generic;

namespace DAL.DbModels
{
    public partial class Town
    {
        public Town()
        {
            Buildings = new HashSet<Building>();
            HeroStats = new HashSet<HeroStat>();
            Heroes = new HashSet<Hero>();
            Monsters = new HashSet<Monster>();
        }

        public int Id { get; set; }
        public int LandscapeId { get; set; }
        public string? Name { get; set; }
        public string? HeroClass_1 { get; set; }
        public string? HeroClass_2 { get; set; }
        public string? Discription { get; set; }
        public byte[]? Picture { get; set; }
        public byte[]? DetailPicture { get; set; }
        public string PictureName { get; set; }

        public virtual Landscape Landscape { get; set; } = null!;
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<HeroStat> HeroStats { get; set; }
        public virtual ICollection<Hero> Heroes { get; set; }
        public virtual ICollection<Monster> Monsters { get; set; }
    }
}
