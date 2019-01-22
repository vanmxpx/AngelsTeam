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
                m.CreateMap<User,UserDto>()
                .ForMember(p=>p.UserType,u=>u.MapFrom(o=>o.UserTypeId))
                .ForMember(p=>p.Contact,u=>u.MapFrom(o=>o.Telegram))
                .ForMember(p=>p.SubLeft,u=>u.MapFrom(o=>o.ExpirationDate));
            });
        }
    }
}