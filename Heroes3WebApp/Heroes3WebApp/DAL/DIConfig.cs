using DAL.DbModels;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DIConfig
    {
        public static void Config(IServiceCollection collection)
        {
            collection.AddScoped<Heroes3DBContext>();
            collection.AddScoped<IRepository<Hero>, HeroRepository>();
            collection.AddScoped<IRepository<Town>, TownRepository>();
            collection.AddScoped<IRepository<Monster>, MonsterRepository>();
            collection.AddScoped<IRepository<Landscape>, LandscapeRepository>();
        }
    }
}
