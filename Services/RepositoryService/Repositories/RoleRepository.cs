using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class UserTypeRepository : RepositoryBase<UserType>, IUserTypeRepository
    {
        public UserTypeRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<UserType> GetUserTypeByUser(User user)
        {
           return await FindOneByConditionAsync(u=>u.Id.Equals(user.UserTypeId));
        }
    }
}
