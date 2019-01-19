using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> GetAll()
        {
            var result = await wrapper.NewsRepository.FindAllAsync();
            return new OkObjectResult(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateNews(News news)
        {
            try
            {
                if (news == null)
                {
                    return BadRequest("News object is null");
                }
                News oldNews = await wrapper.NewsRepository.GetNewsById(news.Id);
                await wrapper.NewsRepository.UpdateNewsAsync(oldNews, news);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }


        }
    }
}