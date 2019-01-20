using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SubscriptionTypeRepository : RepositoryBase<SubscriptionType>, ISubscriptionTypeRepository
    {
        public SubscriptionTypeRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task<IEnumerable<SubscriptionType>> GetAllSubscriptionTypeAsync()
        {
            return FindAllAsync();
        }
    }
}