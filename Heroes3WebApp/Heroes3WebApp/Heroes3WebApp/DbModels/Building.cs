using System;
using System.Collections.Generic;

namespace Heroes3WebApp.DbModels
{
    public partial class Building
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public int CostId { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public byte[]? Picture { get; set; }

        public virtual Cost Cost { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
    }
}
