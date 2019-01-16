using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using AngelsTeam.Services;
using AngelsTeam.Model;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        IRepositoryWrapper wrapper;
        JWTSecretKeyService keyService;
        public AuthController(IRepositoryWrapper wrapper, JWTSecretKeyService keyService)
        {
            this.wrapper = wrapper;
            this.keyService = keyService;
        }

        [HttpPost]
        public async Task<IActionResult> Auth(string Email, string Password)
        {

            if (Email == null || Password == null)
            {
                return BadRequest("Invalid client request");
            }
            Credential userCredential = wrapper.CredentialRepository.GetCredentialByEmail(Email).Result;
            User user = wrapper.UserRepository.GetByIdAsync(userCredential.UserId).Result;
            Role role = await wrapper.RoleRepository.GetRoleByUser(user);
            if (userCredential.Password == Password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyService.SecretKey));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>{                    
                    new Claim(ClaimTypes.Role, role.Name)
                    };

                var tokeOptions = new JwtSecurityToken(
                    claims: claims,

                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }

        }

    }
}