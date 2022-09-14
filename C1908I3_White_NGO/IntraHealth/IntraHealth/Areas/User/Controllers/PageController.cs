using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/page")]
    public class PageController : Controller
    {
        private PageServie pageServie;
        public PageController(PageServie _pageServie)
        {
            pageServie = _pageServie;
        }
        [Route("index/{id}")]
        public IActionResult Index(int id)
        {
            if(pageServie.Find(id) != null)
            {
                ViewBag.page = pageServie.Find(id);
                return View();
            }
            else
            {
                return RedirectToAction("index", "home", new { area = "user" });
            }
            
        }
    }
}
