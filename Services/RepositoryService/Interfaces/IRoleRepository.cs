using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface IRoleRepository: IRepositoryBase<Role> 
    {
        Task<Role> GetRoleByUser (User user);
    }
}