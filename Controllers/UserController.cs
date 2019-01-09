using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AngelsTeam.Services;
using AngelsTeam.Model;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOwner([FromBody] User user)
        {
            await userRepository.CreateAsync(user);
            return new OkObjectResult(user);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await userRepository.GetByIdAsync(id);
            return new OkObjectResult(user);
        }
    }
}