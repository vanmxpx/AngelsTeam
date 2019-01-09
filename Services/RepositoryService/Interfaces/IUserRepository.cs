using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface IUserRepository : ICRUDRepository<User>
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
    public interface INewsRepository: ICRUDRepository<News>
    {
        
    }
}