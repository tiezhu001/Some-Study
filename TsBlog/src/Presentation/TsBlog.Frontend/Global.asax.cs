﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TsBlog.Repositories.PostRepository;
using TsBlog.Services.PostService;
using TsBlog.AutoMappingConfig;

namespace TsBlog.Frontend
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutofacRegister();
            AutoMapperRegister();


        }

        private void AutofacRegister()
        {
            var builder = new ContainerBuilder();

            //注册MVC中的所有控制器
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //注册仓储层服务
            builder.RegisterType<PostRepository>().As<IPostRepository>();

            //注册服务层服务
            builder.RegisterType<PostService>().As<IPostService>();

            //注册过滤器
            builder.RegisterFilterProvider();

            var container = builder.Build();

            //设置依赖注入解析器
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }


        private void AutoMapperRegister()
        {
            new AutoMapperStartupTask().Execute();
        }
    }
}
