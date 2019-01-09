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

        #region ICRUDRepository
        public async Task<User> GetByIdAsync(int userId)
        {
            var user = await FindByConditionAync(o => o.Id.Equals(userId));
            return user.DefaultIfEmpty(new User())
                    .FirstOrDefault();
        }

        public async Task CreateAsync(User user)
        {
            Create(user);
            await SaveAsync();
        }

        public async Task DeleteAsync(User user)
        {
            Delete(user);
            await SaveAsync();
        }

        public async Task UpdateAsync(User user)
        {
            Update(user);
            await SaveAsync();
        }
        #endregion

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var user = await FindAllAsync();
            return user.OrderBy(x => x.Name);
        }
    }
}