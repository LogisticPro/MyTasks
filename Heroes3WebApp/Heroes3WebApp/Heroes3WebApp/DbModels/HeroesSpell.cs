using System;
using System.Collections.Generic;

namespace Heroes3WebApp.DbModels
{
    public partial class HeroesSpell
    {
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int SpellId { get; set; }

        public virtual Hero Hero { get; set; } = null!;
        public virtual Spell Spell { get; set; } = null!;
    }
}
