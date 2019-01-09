using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using AngelsTeam.Model;
using AngelsTeam.Services;

namespace AngelsTeam.Extension
{
    public static class ConfigurationExtension
    {
        public static void AddWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void AddAngelsDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AngelsDbContext>(options => options.UseSqlServer(config.GetConnectionString("Debug")));
        }
    }
}