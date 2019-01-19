using System.Threading.Tasks;
using System.Collections.Generic;

using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public interface INewsRepository: IRepositoryBase<News> 
    {
        Task<News> GetNewsById (int id);
        Task CreateNewsAsync(News news);
        Task UpdateNewsAsync(News oldnews, News news);
        Task DeleteNewsAsync(News news);
    }
}