using DAL;
using Repository;
using Unity;

namespace BAL
{
    public class ProjectDependencies
    {
        public static void RegisterService(ref UnityContainer container)
        {
            container.RegisterType<ProductDbContext>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<ICategoryBL, CategoryBL>();
        }
    }
}
