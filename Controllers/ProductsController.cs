using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();
        public IEnumerable<Product> GetAllProducts()
        {
            GetProduct();
            return products;
        }
        private void GetProduct()
        {
            products.Add(new Product { id = 1, name = "Oppo Find X", category = "Smart Phone", price = 1000 });
            products.Add(new Product { id = 2, name = "Iphone XS max", category = "Smart Phone", price = 2000 });
            products.Add(new Product { id = 3, name = "Dell AlienWare", category = "Laptop", price = 3000 });
            products.Add(new Product { id = 4, name = "C# tutorial", category = "Book", price = 20 });
            products.Add(new Product { id = 5, name = "Computer Vision", category = "Book", price = 30 });
            products.Add(new Product { id = 6, name = "Apple Watch", category = "Watch", price = 500 });
        }
        public IHttpActionResult GetProduct(int id)
        {
            GetProduct();
            var product = products.FirstOrDefault(x => x.id == id);
            
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
