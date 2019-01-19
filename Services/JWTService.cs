using AngelsTeam.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace AngelsTeam.Services
{
    public class JWTService
    {
        private string secretKey;
        public string SecretKey
        {
            get
            {
                return secretKey;
            }
        }
        public JWTService(IConfiguration configuration)
        {
            this.secretKey = configuration.GetSection("SecretKey").Value;
        }
        public string GetValueByHeader(string header)
        {
            string token = header.Remove(0, 7);            
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;
            return jsonToken.Claims.First(claim => claim.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Value;
        }

    }
}