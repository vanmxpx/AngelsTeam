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
        public string GetValueByKey(string token, string key)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;
            return jsonToken.Claims.First(claim => claim.Type == key).Value;
        }

    }
}