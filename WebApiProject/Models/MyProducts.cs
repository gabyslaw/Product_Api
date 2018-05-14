using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models
{
    public static class MyProducts
    {
        public static List<Product> GetProductList()
        {
            var category1 = new Category() { Name = "Laptops" };
            var category2 = new Category() { Name = "Smartphones" };
            var category3 = new Category() { Name = "Automobiles" };

            List<Product> Productlist = new List<Product> {
            new Product()
            {
                Name = "HP",
                Description = "Attractive",
                Price = 670000,
                category = category1
            },

            new Product()
            {
                Name = "Iphone X",
                Description = "Stainless steel band. ",
                Price = 450000,
                category = category2
            },

            new Product()
            {
                Name = "Mercedes Benz",
                Description = "For generations ",
                Price = 44000000,
                category = category3
            }};
            return Productlist;
        }
    }
}