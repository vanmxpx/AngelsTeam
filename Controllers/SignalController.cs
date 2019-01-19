using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

using AngelsTeam.Services;
using AngelsTeam.Model;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class SignalController : Controller
    {
        IRepositoryWrapper wrapper;
        JWTService jwtService;
        public SignalController(IRepositoryWrapper wrapper, JWTService jwtService)
        {
            this.wrapper = wrapper;
            this.jwtService = jwtService;

        }

        [Authorize(Roles = "Admin,User,Free,Unverified")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            string token = HttpContext.Request.Headers["Authorization"];
            string role = jwtService.GetValueByKey(token.Remove(0, 7), "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");
            
            if (role == "Admin" || role == "User")
            {
                var result = await wrapper.SignalRepository.GetAllSignals();
                return new OkObjectResult(result);
            }
            else
            {
                var result = await wrapper.SignalRepository.GetAllPaidSignals();
                return new OkObjectResult(result);
            }

            
        }

    }
}