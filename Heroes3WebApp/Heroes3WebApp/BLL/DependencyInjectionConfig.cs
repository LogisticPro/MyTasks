using DAL;
using Microsoft.Extensions.DependencyInjection;

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
