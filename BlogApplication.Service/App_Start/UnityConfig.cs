using System.Web.Http;
using Blog.DataAccess.Models;
using Blog.DataAccess.Repository;
using Unity;
using Unity.WebApi;

namespace BlogApplication.Service
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType(typeof(IBlogRepository<>), typeof(BlogRespository<>));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}