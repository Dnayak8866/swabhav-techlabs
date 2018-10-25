using AcmeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcmeApi.Repository
{
    public class ProductRepositoy : IRepository<Product>
    {
        private ProductDbContext _dbContext;

        private  List<Product> _products;

        public ProductRepositoy()
        {
            _dbContext = new ProductDbContext();

           
        }

      
        public List<Product> GetAll()
        {
           return  _dbContext.Products.ToList();
        }

        public Product GetByID(int entityId)
        {
            return _dbContext.Products.Where((p) => p.ProductId == entityId).SingleOrDefault();
        }

        public List<Product> GetByname(string entityName)
        {
            return _dbContext.Products.Where(p => p.ProductName.ToLower().Contains(entityName.ToLower())).ToList();
        }

    }
}