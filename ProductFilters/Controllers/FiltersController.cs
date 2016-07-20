using ProductFilters.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductFilters.Controllers
{
    public class FiltersController : Controller
    {


        public List<Product> products = new List<Product>
            {

                new Product
                {
                    ProductId = 1,
                    ProductName = "HTC Legend",
                    ProductType = "Mobile Phone",
                    Price = 250.55m,
                    isAvailable = true
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Canondale",
                    ProductType = "Bicycle",
                    Price = 450.55m,
                    isAvailable = true
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "MassEffect Andromeda",
                    ProductType = "PC Game",
                    Price = 45.66m,
                    isAvailable = true
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "DELL",
                    ProductType = "Desktop Display",
                    Price = 250.89m,
                    isAvailable = false
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "USB",
                    ProductType = "Computer equipment",
                    Price = 15.56m,
                    isAvailable = false
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "HTC Desire",
                    ProductType = "Mobile Phone",
                    Price = 215.56m,
                    isAvailable = false
                }

            };


        public ActionResult AllProducts()
        { 
                                           
            return View(products.ToList());
        }

        public ActionResult LargerThanHundred()
        {
            var filterProducts =
                from p in products
                where p.Price > 100
                select p;

            return View(filterProducts.ToList());
        }

        public ActionResult ProductsAvailable()
        {
            var filterProducts =
                from p in products
                where p.isAvailable == true
                select p;

            return View(filterProducts.ToList());
        }

        public ActionResult ProductsH()
        {
            var filterProducts = from p in products
                                 where p.ProductName.StartsWith("H")
                                 select p;

            return View(filterProducts.ToList());
        }
    }
}