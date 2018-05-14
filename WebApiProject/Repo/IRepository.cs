using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiProject.Models;

namespace WebApiProject.Repo
{
    interface IRepository
    {
       IEnumerable<Product> GetProducts();
    }
}