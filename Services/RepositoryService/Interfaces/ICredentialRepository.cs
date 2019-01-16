using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface ICredentialRepository : IRepositoryBase<Credential> 
    {
        Task CreateCredentialAsync(Credential credential);
        Task UpdateCredentialAsync(Credential oldCredential, Credential credential);
        Task DeleteCredentialAsync(Credential credential);
    }
}