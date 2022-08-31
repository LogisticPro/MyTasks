using System;
using System.Collections.Generic;

namespace DAL.DbModels
{
    public partial class Landscape
    {
        public Landscape()
        {
            Towns = new HashSet<Town>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}
