using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineWatchStore.Models;

namespace OnlineWatchStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            // creating the object to hold the list of categories
            var categories = new List<Category>();
            for(var i=1; i<10; i++)
            {
                categories.Add(new Category { CategoryId = i, Name= "Category" + i.ToString() });
            }
            return View(categories);
        }
        public IActionResult Browse(string category)
        {
            ViewBag.category = category;
            return View();
        }
        public IActionResult AddCategory()
        {
            return View();
        }
    }
}
