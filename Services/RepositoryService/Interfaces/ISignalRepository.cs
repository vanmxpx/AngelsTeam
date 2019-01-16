using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISignalRepository : IRepositoryBase<Signal> 
    {
        Task CreateSignalAsync(Signal signal);
        Task UpdateSignalAsync(Signal oldSignal, Signal signal);
        Task DeleteSignalAsync(Signal signal);
    }
}