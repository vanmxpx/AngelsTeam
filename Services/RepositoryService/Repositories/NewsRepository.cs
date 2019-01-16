using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AngelsTeam.Model;

namespace AngelsTeam.Services{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(AngelsDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task CreateNewsAsync(News news)
        {
            Create(news);
            await SaveAsync();
        }

        public async Task DeleteNewsAsync(News news)
        {
            Delete(news);
            await SaveAsync();
        }

        public async Task UpdateNewsAsync(News oldnews, News news)
        {
            oldnews.Clone(news);
            Update(oldnews);
            await SaveAsync();
        }
    }
}