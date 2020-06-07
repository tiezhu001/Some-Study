namespace TsBlog.Repositories
{
    /// <summary>
    /// 静态配置类
    /// </summary>
    public static class Config
    {
        private static readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TsBlogMySQLDb"].ConnectionString;

        public static string ConnectionString
        {
            get { return _connectionString; }
        }
    }
}
