using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISubscriptionRepository: IRepositoryBase<Subscription> 
    {
        Task CreateSubscriptionAsync(Subscription subscription);
        Task UpdateSubscriptionAsync(Subscription oldSubscription, Subscription subscription);
        Task DeleteSubscriptionAsync(Subscription subscription);
    }
}