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
    public class NewsController : Controller
    {
        IRepositoryWrapper wrapper;
        public NewsController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var result = await wrapper.NewsRepository.FindAllAsync();
            return new OkObjectResult(result);
        }
        // [HttpPost]
        // public async Task<IActionResult> CreateOwner( User user)
        // {
        //     await wrapper.UserRepository.CreateAsync(user);
        //     return new OkObjectResult(user);
        // }
        // [HttpGet]
        // public async Task<IActionResult> GetUserById(int id)
        // {
        //     var user = await wrapper.UserRepository.GetByIdAsync(id);
        //     return new OkObjectResult(user);
        // }
    }
}