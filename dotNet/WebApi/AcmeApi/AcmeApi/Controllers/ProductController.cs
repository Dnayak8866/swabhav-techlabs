using AcmeApi.Models;
using AcmeApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AcmeApi.Controllers
{

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/Acme")]
    public class ProductController:ApiController
    {
        private IRepository<Product> _productRepo = new ProductRepositoy();


        
      
        [Route("Allproducts")]
        public IHttpActionResult GetAllProducts()
        {
            return Ok(_productRepo.GetAll());
        }

        [Route("product/{id}")]
        public IHttpActionResult GetProductById(int id)
        {
            return Ok(_productRepo.GetByID(id));
        }
        
        [Route("product/{name:alpha}")]
        public IHttpActionResult GetProductByName(string name)
        {
          
            return Ok(_productRepo.GetByname(name));
        }


    }
}