using BLL.Dto;
using DAL.DbModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MonsterService : IMonsterService
    {
        private readonly IRepository<Monster> _repository;

        public MonsterService(IRepository<Monster> repository)
        {
            _repository = repository;
        }
        public List<MonsterListDto> GetList()
        {
            var result = new List<MonsterListDto>();

            var monsters = _repository.GetAll();

            foreach (var monster in monsters)
            {
                result.Add(new MonsterListDto()
                {
                    Id = monster.Id,
                    TownId = monster.TownId,
                    Picture = monster.Picture,
                    Name = monster.Name,
                    Hp = monster.Hp,
                    Attack = monster.Attack,
                    Defence = monster.Defence,
                    Damage = monster.Damage,
                    Speed = monster.Speed,
                    Discription = monster.Discription,
                    Level = monster.Level
                });
            }

            return result;
        }
    }
}
