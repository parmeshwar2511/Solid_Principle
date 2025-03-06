using AutoMapper;
using BAL;
using Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Web_UI_client
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICategoryBL, CategoryBL>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>(); // your AutoMapper profile
            });
            IMapper mapper = config.CreateMapper();

            // 2. Register AutoMapper instance
            container.RegisterInstance<IMapper>(mapper);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}