using AngelsTeam.Model;
using AngelsTeam.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngelsTeam.Extension
{
    public static class DbContextExtension
    {
        public static void AddAngelsDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AngelsDbContext>(options => options.UseSqlServer(config.GetConnectionString("Debug")));
            //services.AddDbContext<AngelsDbContext>(options => options.UseInMemoryDatabase("Debug"));
        }
    }
}