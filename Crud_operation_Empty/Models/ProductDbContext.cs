using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_operation_Empty.Models
{
    public class ProductDbContext : DbContext
    {
       public DbSet<Category> categories { get; set; }

        public DbSet<Product> products { get; set; }

        public DbSet<Self_Information> self_Information { get; set; }
    }
}