using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using AngelsTeam.Model;
using AngelsTeam.Services;

namespace AngelsTeam.Extension
{
    public static class DbContextExtension
    {
        public static void AddAngelsDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AngelsDbContext>(options => options.UseSqlServer(config.GetConnectionString("Debug")));
        }
    }
}