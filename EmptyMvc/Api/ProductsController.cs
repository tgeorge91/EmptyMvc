using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmptyMvc.Api
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("api/products")]
        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "iPhone 4S" });
            products.Add(new Product { Id = 1, Name = "iPhone 5" });
            products.Add(new Product { Id = 1, Name = "iPhone 5S" });

            return products;
        }
    }

    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}