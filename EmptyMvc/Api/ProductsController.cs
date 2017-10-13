using System.Collections.Generic;
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

            products.Add(new Product { Id = 1, Name = "iPhone 7" });
            products.Add(new Product { Id = 2, Name = "iPhone 7+" });
            products.Add(new Product { Id = 3, Name = "iPhone 8" });
            products.Add(new Product { Id = 3, Name = "iPhone 8+" });
            products.Add(new Product { Id = 3, Name = "iPhone X" });

            return products;
        }
    }

    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}