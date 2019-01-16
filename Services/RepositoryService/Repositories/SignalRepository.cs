using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class SignalRepository : RepositoryBase<Signal>, ISignalRepository
    {
        public SignalRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task CreateSignalAsync(Signal signal)
        {
             Create(signal);
            await SaveAsync();
        }

        public async Task DeleteSignalAsync(Signal signal)
        {
             Create(signal);
            await SaveAsync();
        }

        public async Task UpdateSignalAsync(Signal oldSignal, Signal signal)
        {
            oldSignal.Clone(signal);
            Update(oldSignal);
            await SaveAsync();
        }
    }
}