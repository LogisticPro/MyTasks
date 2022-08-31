using DAL;
using DAL.DbModels;
using DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DependencyInjectionConfig
    {
        public static void Config(IServiceCollection collection)
        {
            DIConfig.Config(collection);
        }
    }
}
