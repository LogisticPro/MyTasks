using Microsoft.Extensions.DependencyInjection;
using DAL;
using BLL.Services;

namespace BLL
{
    public class DependencyInjectionConfig
    {
        public static void Config(IServiceCollection collection)
        {
            DIConfig.Config(collection);

            collection.AddScoped<IAuthorService, AuthorService>();
            collection.AddScoped<IPhotoService, PhotoService>();
            collection.AddScoped<ITextService, TextService>();
        }
    }
}