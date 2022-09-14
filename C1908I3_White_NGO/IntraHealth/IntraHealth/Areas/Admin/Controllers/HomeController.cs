using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/home")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("")]
        
        public IActionResult Index()
        {
            @ViewBag.Title = "Home";
            return View();
        }
    }
}
