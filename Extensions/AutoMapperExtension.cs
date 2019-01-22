using AutoMapper;
using AngelsTeam.Model;
using AngelsTeam.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;


namespace AngelsTeam.Extension
{
    public static class AutoMapperExtension
    {
        public static void AddMapper(this IServiceCollection services)
        {
            Mapper.Initialize(m=>{
                m.CreateMap<News,NewsDto>();
                m.CreateMap<IEnumerable<News>,List<NewsDto>>();
            });
        }
    }
}