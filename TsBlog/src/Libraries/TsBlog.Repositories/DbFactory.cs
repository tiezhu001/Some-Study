using SqlSugar;

namespace TsBlog.Repositories
{
    /// <summary>
    /// 数据库工厂
    /// </summary>
    public  class DbFactory
    {
        public static SqlSugarClient GetSqlSugarClient()
        {
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,//是否自动释放数据库,设为ture我们不需要close或者using操作
                InitKeyType = InitKeyType.Attribute //初始化逐渐和自增列信息的方式
                // Attribute：表示从属性中读取主键和自增列信息
                //systemTable：表示自动从数据库读取主键自增列的信息
            });

            return db;
        }
    }
}
