using CrudDemos_2Solid.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CrudDemos_2Solid
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ProductDbContext>();

            //container.RegisterType<ICategoryDAL,CategoryDAL>();
            container.RegisterType<ICategoryDAL, CategoryDAL>();

            container.RegisterType<ICategoryBAL, CategoryBAL>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductBAL, ProductBAL>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}