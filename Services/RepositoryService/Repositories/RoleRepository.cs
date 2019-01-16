using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Role> GetRoleByUser(User user)
        {
           return await FindOneByConditionAsync(u=>u.Id.Equals(user.RoleId));
        }
    }
}
