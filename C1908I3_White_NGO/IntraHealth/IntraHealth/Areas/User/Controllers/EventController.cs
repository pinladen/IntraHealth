using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{

    [Area("user")]
    [Route("event")]
    public class EventController : Controller
    {
        private EventService eventService;
        public EventController(EventService _eventService)
        {
            eventService = _eventService;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.evt = eventService.FindAll();
            return View();
        }
    }
}
