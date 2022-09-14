using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/page")]
    public class PagesController : Controller
    {
        private PageServie pageServie;
        private CategoryService categoryService;
        private IWebHostEnvironment webHostEnvironment;
        public PagesController(PageServie _pageServie,CategoryService _categoryService, IWebHostEnvironment _webHostEnvironment)
        {
            pageServie = _pageServie;
            categoryService = _categoryService;
            webHostEnvironment = _webHostEnvironment;
    }

        // GET : ALL list
        [Route("list")]
        [Route("")]
        public IActionResult List()
        {
            ViewBag.ev = pageServie.FindAll();
            return View("list");
        }

        // GET : Create 
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            SelectList categoryList = new SelectList(categoryService.FindAll(), "IdCategory", "NameCategory");
            ViewBag.category = categoryList;
            return View("Create", new Page());
        }
        // Post : Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Page page , IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "user/assets/images/pages", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                page.PhotoPage = fileName + "." + ext;            
            }
            else
            {                
                page.PhotoPage = "no-image.jpg";
            }
            page.TimeCreatePage = DateTime.Now;
            pageServie.Create(page);
            return RedirectToAction("list");
        }


        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            SelectList categoryList = new SelectList(categoryService.FindAll(), "IdCategory", "NameCategory");
            ViewBag.category = categoryList;
            ViewBag.image = pageServie.Find(id).PhotoPage;
            return View("Update", pageServie.Find(id));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(Page page, IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "user/assets/images/pages", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                page.PhotoPage = fileName + "." + ext;
            }
            pageServie.Update(page);
            return RedirectToAction("list");
        }

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var contract = pageServie.Find(id);
            if (contract != null)
            {
                return View("detail", contract);
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
            pageServie.Delete(id);
            return RedirectToAction("list");
        }
    }
}
