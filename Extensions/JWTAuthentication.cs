using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

using AngelsTeam.Model;
using AngelsTeam.Services;

namespace AngelsTeam.Extension
{
    public static class JWTAuthentication
    {
        public static void AddJWTAuthentication(this IServiceCollection services, IConfiguration config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    RequireExpirationTime = false,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("SecretKey").Value))
                };
            });
        }
        public static void AddJWTSecureKeyService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<JWTService>();
        }
    }
}