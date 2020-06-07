using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsBlog.Domain.Entities;

namespace TsBlog.Repositories.PostRepository
{
   public interface IPostRepository
    {
        Post FindById(int id);

        /// <summary>
        /// 查找所有数据(无分页,慎用)
        /// </summary>
        /// <returns></returns>
        IEnumerable<Post> FindAll();

        int Insert(Post entity);

        bool Update(Post entity);

        bool Delete(Post entity);

        bool DeleteById(object id);

        /// <summary>
        /// 删除指定id的集合
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        bool DeleteByIds(object[] ids);
    }
}
