using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class HeroListDto
    {
        public int Id { get; set; }
        public int TownId { get; set; }
        public string? TownName { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public int Type { get; set; }
        public byte[]? Picture { get; set; }
        public byte[]? TownPicture { get; set; }
    }
}
