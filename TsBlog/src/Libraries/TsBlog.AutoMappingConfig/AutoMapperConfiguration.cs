using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TsBlog.Domain.Entities;
using TsBlog.Services.ViewModels;

namespace TsBlog.AutoMappingConfig
{
    /// <summary>
    /// AutoMapper全局配置静态类
    /// </summary>
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration MapperConfiguration { get; private set; }
        public static IMapper Mapper { get; private set; }

        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostVM>()
                .ForMember(dest => dest.IsDeleted, dest => dest.MapFrom(souc => souc.IsDeleted ? "是" : "否"));
                cfg.CreateMap<PostVM, Post>();

            });
            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}
