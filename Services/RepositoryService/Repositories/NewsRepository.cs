using System.Collections.Generic;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class NewsRepository : RepositoryBase<NewsRepository>, INewsRepository
    {
        public NewsRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public Task CreateAsync(News entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(News entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<News>> GetAllNewsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<News> GetByIdAsync(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(News entity)
        {
            throw new System.NotImplementedException();
        }
    }
}