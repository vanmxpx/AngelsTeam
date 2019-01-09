using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISubscriptionRepository: ICRUDRepository<Subscription>
    {
        Task<IEnumerable<Subscription>> GetAllSubscriptionAsync();
        Task<IEnumerable<Subscription>> GetAllSubscriptionByUserAsync(User user);
        Task<IEnumerable<Subscription>> GetAllSubscriptionBySubscriptionTypeAsync(SubscriptionType user);
    }
}