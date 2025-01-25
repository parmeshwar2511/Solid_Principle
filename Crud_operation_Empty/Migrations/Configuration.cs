namespace Crud_operation_Empty.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Crud_operation_Empty.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Crud_operation_Empty.Models.ProductDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.products.Add(new Models.Product() { Id = 1, Name = "Laptop", Price = 20000 });

            context.self_Information.Add(new Models.Self_Information() { Id = 1, Name = "Ajay Bhosle", Mono = 9322864132 });
        }
    }
}
