using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISubscriptionTypeRepository : IRepositoryBase<SubscriptionType>
    {
        Task<IEnumerable<SubscriptionType>> GetAllSubscriptionTypeAsync();
    }
}