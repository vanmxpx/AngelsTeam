using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SubscriptionTypeRepository : RepositoryBase<SubscriptionType>, ISubscriptionTypeRepository
    {
        public SubscriptionTypeRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task CreateAsync(SubscriptionType entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(SubscriptionType entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SubscriptionType>> GetAllSubscriptionTypeAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<SubscriptionType> GetByIdAsync(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(SubscriptionType entity)
        {
            throw new System.NotImplementedException();
        }
    }
}