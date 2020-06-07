using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TsBlog.Domain.Entities;

namespace TsBlog.Services.PostService
{
    public interface IPostService
    {
        Post FindById(int id);
        IEnumerable<Post> FindAll();
        int Insert(Post entity);
        bool Update(Post entyty);
        bool Delete(Post entity);
        bool DeleteById(object id);
        bool DeleteByIds(object[] ids);

    }

}
