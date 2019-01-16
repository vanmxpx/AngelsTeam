using AngelsTeam.Model;
using Microsoft.Extensions.Configuration;

namespace AngelsTeam.Services
{
    public class JWTSecretKeyService
    {
        private string secretKey;
        public JWTSecretKeyService(IConfiguration configuration)
        {
            this.secretKey = configuration.GetSection("SecretKey").Value;
        }
        public string SecretKey
        {
            get
            {
                return secretKey;
            }
        }

    }
}