using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface IUserRepository : IRepositoryBase<User>
        {
            Task<User> GetByIdAsync(int userId);
            Task<IEnumerable<User>> GetAllUsersAsync();
            Task CreateUserAsync(User user);
            Task UpdateUserAsync(User oldUser, User user);
            Task DeleteUserAsync(User user);
        }
}