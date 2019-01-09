using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task CreateAsync(Subscription entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Subscription entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetAllSubscriptionAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetAllSubscriptionBySubscriptionTypeAsync(SubscriptionType user)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetAllSubscriptionByUserAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<Subscription> GetByIdAsync(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Subscription entity)
        {
            throw new System.NotImplementedException();
        }
    }
}