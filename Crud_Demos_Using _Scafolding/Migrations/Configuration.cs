namespace Crud_Demos_Using__Scafolding.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Crud_Demos_Using__Scafolding.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Crud_Demos_Using__Scafolding.Models.ProductDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.categories.Add(new Models.Category() { Id = 1, Name = "Mobile", Rating = 5 });
        }
    }
}
