using Dependecy_Crud.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Dependecy_Crud
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ProductDbContext1>();
            container.RegisterType <ICategoryDAL, CategoryDAL>();
            container.RegisterType<ICustomerBAL, CategoryBAL>();
            container.RegisterType<IproductRepository, ProductRepositories>();
            container.RegisterType<IProductBAL, ProductBAL>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}