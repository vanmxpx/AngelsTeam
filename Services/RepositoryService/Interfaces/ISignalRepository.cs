using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ISignalRepository : ICRUDRepository<Signal>
    {
        Task<IEnumerable<Signal>> GetAllFreeSignalAsync();
        Task<IEnumerable<Signal>> GetAllSignalAsync();
    }
}