﻿using System;
using System.Collections.Generic;

namespace Heroes3WebApp.DbModels
{
    public partial class Monster
    {
        public int Id { get; set; }
        public int? TownId { get; set; }
        public int CostId { get; set; }
        public string? Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public string? Discription { get; set; }
        public byte[]? Picture { get; set; }

        public virtual Cost Cost { get; set; } = null!;
        public virtual Town? Town { get; set; }
    }
}
