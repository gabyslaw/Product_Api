namespace WebApiProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiProject.Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiProject.Context.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var Products = MyProducts.GetProductList();
            context.Set<Product>().AddRange(Products);
            context.SaveChanges();
        }
    }
}
