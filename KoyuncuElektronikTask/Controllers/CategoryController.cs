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
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult CategoryList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            categoryRepository.AddData(c);
            var jsonCategory = JsonConvert.SerializeObject(c);
            return Json(jsonCategory);
        }

        public IActionResult Categories()
        {
            var jsonData = JsonConvert.SerializeObject(categoryRepository.ListData());
            return Json(jsonData);
        }


    }
}
