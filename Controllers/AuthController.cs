using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AngelsTeam.Model;
using AngelsTeam.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        IRepositoryWrapper wrapper;
        JWTService keyService;
        public AuthController(IRepositoryWrapper wrapper, JWTService keyService)
        {
            this.wrapper = wrapper;
            this.keyService = keyService;
        }

        [HttpPost]
        public async Task<IActionResult> Auth(string email, string password)
        {

            if (email == null || password == null)
            {
                return BadRequest("Invalid client request");
            }
            Credential userCredential = await wrapper.CredentialRepository.GetCredentialByEmail(email);
            if (userCredential == null)
            {
                return Unauthorized();
            }
            User user = wrapper.UserRepository.GetByIdAsync(userCredential.UserId).Result;
            UserType role = await wrapper.UserTypeRepository.GetUserTypeByUser(user);
            if (userCredential.Password == password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyService.SecretKey));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Role, role.Name)
                    };

                var tokenOptions = new JwtSecurityToken(
                    claims: claims,
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString, Profile = AutoMapper.Mapper.Map<User,UserDto>(user) });
            }
            else
            {
                return Unauthorized();
            }

        }

    }
}