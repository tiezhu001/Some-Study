using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TsBlog.Domain.Entities;

namespace TsBlog.Repositories.PostRepository
{
    /// <summary>
    /// POST表的数据库操作类
    /// </summary>
    public class PostRepository : IPostRepository
    {
        //public Post FindById(int id)
        //{
        //    #region Ado.net 读取方式
        //    //var ds = MySqlHelper.Query("SELECT * FROM tb_post WHERE ID=@id", new MySqlParameter("@ID", id));
        //    //var entity = ds.Tables[0].ToList<Post>().FirstOrDefault();
        //    #endregion

        //    using (var db = DbFactory.GetSqlSugarClient())
        //    {
        //        var entity = db.Queryable<Post>().Single(x => x.Id == id);
        //        return entity;
        //    }
        //}

        //public List<Post> FindAll()
        //{
        //    #region Ado.net 读取方式
        //    //var ds = MySqlHelper.Query("SELECT * FROM tb_post");
        //    //return ds.Tables[0].ToList<Post>();
        //    #endregion

        //    using (var db = DbFactory.GetSqlSugarClient())
        //    {
        //        var entity = db.Queryable<Post>().ToList();
        //        return entity;
        //    }
        //}

        public Post FindById(int id)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var entity = db.Queryable<Post>().Single(x => x.Id == id);
                return entity;
            }
        }

        IEnumerable<Post> IPostRepository.FindAll()
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var entity = db.Queryable<Post>().ToList();
                return entity;
            }
        }

        public int Insert(Post entity)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var i = db.Insertable(entity).ExecuteReturnBigIdentity();
                return (int)i;
            }
        }

        public bool Update(Post entity)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                // 这种方式用主键的方式找到行
                var i = db.Updateable(entity).ExecuteCommand();
                return i > 0;
            }
        }

        public bool Delete(Post entity)
        {
            using(var db = DbFactory.GetSqlSugarClient())
            {
                var i = db.Deleteable(entity).ExecuteCommand();
                return i > 0;
            }
        }

        public bool DeleteById(object id)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var i = db.Deleteable<Post>(id).ExecuteCommand();
                return i > 0;
            }
        }

        public bool DeleteByIds(object[] ids)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var i = db.Deleteable<Post>().In(ids).ExecuteCommand();
                return i > 0;
            }
        }

       
    }
}
