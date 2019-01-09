using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SignalRepository : RepositoryBase<SignalRepository>, ISignalRepository
    {
        public SignalRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task CreateAsync(Signal entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Signal entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Signal>> GetAllFreeSignalAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Signal>> GetAllSignalAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Signal> GetByIdAsync(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Signal entity)
        {
            throw new System.NotImplementedException();
        }
    }
}