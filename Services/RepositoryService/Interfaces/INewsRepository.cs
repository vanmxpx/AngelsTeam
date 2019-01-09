using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface INewsRepository: ICRUDRepository<News>
    {
        Task<IEnumerable<News>> GetAllNewsAsync();
    }
}