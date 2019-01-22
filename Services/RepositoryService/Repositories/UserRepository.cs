using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AngelsDbContext repositoryContext) : base(repositoryContext) { }

        public async Task CreateUserAsync(User user)
        {
            Create(user);
            await SaveAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            Delete(user);
            await SaveAsync();
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return FindAllAsync();
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            return await FindOneByConditionAsync(o => o.Id.Equals(userId));
        }

        public async Task UpdateUserAsync(User oldUser, User user)
        {
            oldUser.Clone(user);
            Update(oldUser);
            await SaveAsync();
        }
    }
}