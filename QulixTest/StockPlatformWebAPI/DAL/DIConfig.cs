using DAL.DbModels;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public class DIConfig
    {
        public static void Config(IServiceCollection collection)
        {
            collection.AddScoped<StockPlatformDBContext>();
            collection.AddScoped<IAuthorRepository<Author>, AuthorRepository>();
            collection.AddScoped<IPhotoRepository<Photo>, PhotoRepository>();
            collection.AddScoped<ITextRepository<Text>, TextRepository>();
        }
    }
}
