using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Laptop",
                Description = "HP Laptop with 8GB RAM",
                Category = "Electronics",
                Price = 55000
            },

            new Product()
            {
                Id = 2,
                Name = "Mobile",
                Description = "Samsung Android Mobile",
                Category = "Electronics",
                Price = 25000
            },

            new Product()
            {
                Id = 3,
                Name = "Keyboard",
                Description = "Wireless Keyboard",
                Category = "Accessories",
                Price = 1500
            },

            new Product()
            {
                Id = 4,
                Name = "Mouse",
                Description = "Wireless Optical Mouse",
                Category = "Accessories",
                Price = 800
            }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}