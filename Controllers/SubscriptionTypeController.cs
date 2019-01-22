using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelsTeam.Model;
using AngelsTeam.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngelsTeam.Controllers
{
    [Route("api/[controller]")]
    public class SubscriptionTypeController : Controller
    {
        IRepositoryWrapper wrapper;
        public SubscriptionTypeController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }

        [HttpGet]
        public IEnumerable<SubscriptionType> Get()
        {
            return wrapper.SubscriptionTypeRepository.FindAllAsync().Result;
        }

    }
}