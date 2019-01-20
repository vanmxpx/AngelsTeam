using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using AngelsTeam.Model;
using AngelsTeam.Services;

namespace AngelsTeam.Extension
{
    public static class WrapperExtension
    {
        public static void AddWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}