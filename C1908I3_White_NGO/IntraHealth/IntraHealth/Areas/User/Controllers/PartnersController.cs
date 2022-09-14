using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/partners")]
    public class PartnersController : Controller
    {
        private OtherPartnerService OtherPartnerService;
        public PartnersController(OtherPartnerService _OtherPartnerService)
        {
            OtherPartnerService = _OtherPartnerService;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.partners = OtherPartnerService.FindAll();
            return View();
        }

        
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            ViewBag.partner = OtherPartnerService.Find(id);
            return View("detail");
        }
    }
}
