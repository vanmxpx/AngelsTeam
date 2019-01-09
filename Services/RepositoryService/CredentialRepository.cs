using System.Threading.Tasks;
using System.Linq;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public class CredentialRepository : RepositoryBase<Credential>, ICredentialRepository
    {
        public CredentialRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }
        #region ICRUDRepository
        public async Task<Credential> GetByIdAsync(int entityId)
        {
            var credential = await FindByConditionAync(o => o.Id.Equals(entityId));
            return credential.DefaultIfEmpty(new Credential())
                    .FirstOrDefault();
        }
        public async Task CreateAsync(Credential entity)
        {
            Create(entity);
            await SaveAsync();
        }
        public async Task UpdateAsync(Credential entity)
        {
            Update(entity);
            await SaveAsync();
        }
        public async Task DeleteAsync(Credential entity)
        {
            Delete(entity);
            await SaveAsync();
        }
        #endregion
    }
}