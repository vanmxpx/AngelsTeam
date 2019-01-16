using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public class CredentialRepository : RepositoryBase<Credential>, ICredentialRepository
    {
        public CredentialRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task CreateCredentialAsync(Credential credential)
        {
            Create(credential);
            await SaveAsync();
        }

        public async Task DeleteCredentialAsync(Credential credential)
        {
            Delete(credential);
            await SaveAsync();
        }

        public async Task<Credential> GetCredentialByEmail(string email)
        {
           return await FindOneByConditionAsync(c=>c.Email == email);           
        }

        public async Task UpdateCredentialAsync(Credential oldCredential, Credential credential)
        {
            oldCredential.Clone(credential);
            Update(oldCredential);
            await SaveAsync();
        }
    }
}