using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.Repo;

namespace WebApiProject.Controllers.api
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private ProductRepo productRepo;
        public ProductApiController()
        {
            productRepo = new ProductRepo();
        }
       
        [Route("list")]
        // GET: ProductApi
        public HttpResponseMessage GetProducts()
        {

            try
            {
                IEnumerable<Product> products = productRepo.GetProducts();
                return this.Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.Created, products);
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.Created, ex.Message);
            }
        }


    }
}