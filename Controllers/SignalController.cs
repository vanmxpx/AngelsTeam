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
            try
            {
                string role = jwtService.GetValueByHeader(HttpContext.Request.Headers["Authorization"]);

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
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateSignal(Signal signal)
        {
            try
            {
                var oldSignal = await wrapper.SignalRepository.GetById(signal.Id);
                await wrapper.SignalRepository.UpdateSignalAsync(oldSignal, signal);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }


        }

    }
}