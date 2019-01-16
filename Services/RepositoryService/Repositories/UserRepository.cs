using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

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
            var user = await FindByConditionAync(o => o.Id.Equals(userId));
            return user.DefaultIfEmpty(new User())
                    .FirstOrDefault();
        }

        public async Task UpdateUserAsync(User oldUser, User user)
        {
            oldUser.Clone(user);
            Update(oldUser);
            await SaveAsync();            
        }
    }
}