using KoyuncuElektronikTask.Data.Models;
using KoyuncuElektronikTask.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoyuncuElektronikTask.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        public IActionResult ProductList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            productRepository.AddData(p);
            var jsonCategory = JsonConvert.SerializeObject(p);
            return Json(jsonCategory);
        }

        public IActionResult Products()
        {
            var jsonData = JsonConvert.SerializeObject(productRepository.ListData());
            return Json(jsonData);
        }
    }
}
