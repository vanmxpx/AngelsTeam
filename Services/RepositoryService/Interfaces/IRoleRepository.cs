using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface IUserTypeRepository: IRepositoryBase<UserType> 
    {
        Task<UserType> GetUserTypeByUser (User user);
    }
}