using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class TownListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Picture { get; set; }
    }
}
