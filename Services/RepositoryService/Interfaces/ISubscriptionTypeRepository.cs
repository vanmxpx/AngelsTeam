using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISubscriptionTypeRepository: ICRUDRepository<SubscriptionType>
    {
        Task<IEnumerable<SubscriptionType>> GetAllSubscriptionTypeAsync();
    }
}