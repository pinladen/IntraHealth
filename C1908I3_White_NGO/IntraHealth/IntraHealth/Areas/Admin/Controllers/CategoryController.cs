using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Controllers
{
    [Area("admin")]
    [Route("admin/category")]
    public class CategoryController : Controller
    {

        private CategoryService categoryService;
        public CategoryController(CategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        // GET : ALL list
        [Route("list")]
        public IActionResult List()
        {
            ViewBag.ev = categoryService.FindAll();
            return View("list");
        }

        // GET : Create 
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new Category());
        }
        // Post : Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Category category)
        {
            categoryService.Create(category);
            return RedirectToAction("list");
        }


        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("Update", categoryService.Find(id));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(Category category)
        {

            categoryService.Update(category);
            return RedirectToAction("list");
        }

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var category = categoryService.Find(id);
            if (category != null)
            {
                return View("detail", category);
            }
            else
            {
                ViewBag.errMessege = "not find event";
                return RedirectToAction("~views/error/error.cshtml");
            }

        }
        // GET : Delete
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            categoryService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
