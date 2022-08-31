using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class MonsterListDto
    {
        public int Id { get; set; }
        public int? TownId { get; set; }
        public string? Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public string? Damage { get; set; }
        public int Speed { get; set; }
        public string? Discription { get; set; }
        public byte[]? Picture { get; set; }
        public int Level { get; set; }
    }
}
