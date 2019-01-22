using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelsTeam.Model;
using AngelsTeam.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        IRepositoryWrapper wrapper;
        public UserController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var result = await wrapper.UserRepository.GetAllUsersAsync();
            return new OkObjectResult(result);
        }

        [Authorize(Roles = "Admin,User,Free,Unverified")]
        [HttpPost]
        public async Task<IActionResult> UpdateUser(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("User object is null");
                }
                User oldUser = await wrapper.UserRepository.GetByIdAsync(user.Id);
                await wrapper.UserRepository.UpdateUserAsync(oldUser, user);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }

        }
    }
}