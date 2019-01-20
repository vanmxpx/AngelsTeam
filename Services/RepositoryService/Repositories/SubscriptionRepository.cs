using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task CreateSubscriptionAsync(Subscription subscription)
        {
            Create(subscription);
            await SaveAsync();
        }

        public async Task DeleteSubscriptionAsync(Subscription subscription)
        {
            Delete(subscription);
            await SaveAsync();
        }

        public async Task UpdateSubscriptionAsync(Subscription oldSubscription, Subscription subscription)
        {
            oldSubscription.Clone(subscription);
            Update(oldSubscription);
            await SaveAsync();
        }
    }
}