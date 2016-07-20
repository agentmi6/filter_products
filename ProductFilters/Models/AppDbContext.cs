using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductFilters.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() 
            : base("name=AppFilter")
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}