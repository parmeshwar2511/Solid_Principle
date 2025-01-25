using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_Demos_Using__Scafolding.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
    }
}