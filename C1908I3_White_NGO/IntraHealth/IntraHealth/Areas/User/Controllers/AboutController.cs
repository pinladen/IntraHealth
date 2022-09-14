using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/about")]
    public class AboutController : Controller
    {

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
