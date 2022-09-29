using BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ITownService
    {
        public List<TownListDto> GetList();
        public TownDetailDto GetDetail(int id);
        public void Delete(int id);
        public void Create(TownDetailDto town);
    }
}
