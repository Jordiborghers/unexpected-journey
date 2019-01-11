using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevOpsBrosShop.Models;
using DevOpsBrosShop.Models.ViewModels;

namespace DevOpsBrosShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new ProductsViewModel
            {
                Products = new []
                {
                    new Product
                    {
                        Id = 1,
                        Name = "1-UP Mushroom",
                        Price = 50.00m,
                        ImageUrl = "images/1-Up-Mushroom.png"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Mushroom",
                        Price = 412.87m,
                        ImageUrl = "images/Mushroom.png"
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Fire Flower",
                        Price = 64.30m,
                        ImageUrl = "images/Fire-Flower.png"
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Ice Flower",
                        Price = 75.97m,
                        ImageUrl = "images/Ice-Flower.png"
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Super Star",
                        Price = 150.49m,
                        ImageUrl = "images/Super-Star.png"
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Super Leaf",
                        Price = 324.25m,
                        ImageUrl = "images/Super-Leaf.png"
                    }
                }
            };
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
