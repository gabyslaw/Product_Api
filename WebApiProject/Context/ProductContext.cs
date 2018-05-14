using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiProject.Models;

namespace WebApiProject.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base($"name={nameof(ProductContext)}")
        {
        }

        public DbSet<Product> products { get; set; }

    }
}