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
        IRepositoryWrapper wrapper;
        public UserController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOwner( User user)
        {
            await wrapper.UserRepository.CreateAsync(user);
            return new OkObjectResult(user);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await wrapper.UserRepository.GetByIdAsync(id);
            return new OkObjectResult(user);
        }
    }
}