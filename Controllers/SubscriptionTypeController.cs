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
    public class SubscriptionTypeController : Controller
    {
        IRepositoryWrapper wrapper;
        public SubscriptionTypeController(IRepositoryWrapper wrapper)
        {
            this.wrapper = wrapper;
        }

        [HttpGet]
        public IEnumerable<SubscriptionType> Get(){
           return wrapper.SubscriptionTypeRepository.FindAllAsync().Result;
        }
        
    }
}