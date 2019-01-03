using AngelsTeam.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AngelsTeam.Services
{
    public static class DbService
    {
        public static void AddAngelsDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AngelsDbContext>(options => options.UseSqlServer(config.GetConnectionString("Debug")));
        }
    }
}