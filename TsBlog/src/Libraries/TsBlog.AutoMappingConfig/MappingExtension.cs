using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsBlog.Domain.Entities;
using TsBlog.Services.ViewModels;

namespace TsBlog.AutoMappingConfig
{
   public static class MappingExtension
    {
        public static TDestination MapTo<TSource,TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        #region post
        public static PostVM ToModel(this Post entity)
        {
            return entity.MapTo<Post, PostVM>();
        }

        public static Post ToEntity(this PostVM model)
        {
            return model.MapTo<PostVM, Post>();
        }

        #endregion
    }
}
