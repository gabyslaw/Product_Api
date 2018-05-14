using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiProject.Context;
using WebApiProject.Models;

namespace WebApiProject.Repo
{
    public class ProductRepo : IRepository
    {
        private ProductContext GetProductContext;
        public ProductRepo()
        {
            GetProductContext = new ProductContext();
        }
        public IEnumerable<Product> GetProducts()
        {
            return GetProductContext.Set<Product>().ToList();
        }
    }
}