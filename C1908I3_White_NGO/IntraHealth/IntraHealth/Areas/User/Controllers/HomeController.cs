using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user")]
    [Route("user/home")]
    public class HomeController : Controller
    {
        private EventService eventService;
        public HomeController(EventService _eventService)
        {
            eventService = _eventService;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.evt= eventService.FindAll();
            return View();
        }
    }
}
