using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/otherpartner")]
    public class OtherPartnerController : Controller
    {
        private OtherPartnerService otherPartnerService;
        public OtherPartnerController(OtherPartnerService _otherPartnerService)
        {
            otherPartnerService = _otherPartnerService;
        }

        // list all event
        [Route("list")]
        public IActionResult List()
        {

            ViewBag.oth = otherPartnerService.FindAll();
            return View("list");
        }

        // Create event
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new OtherPartner());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(OtherPartner otherPartner)
        {

            otherPartnerService.Create(otherPartner);
            return RedirectToAction("list");
        }


        // update event
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("Update", otherPartnerService.Find(id));
        }
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(OtherPartner otherPartner)
        {

            otherPartnerService.Update(otherPartner);
            return RedirectToAction("list");
        }
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var oth = otherPartnerService.Find(id);
            if (oth != null)
            {
                return View("detail", oth);
            }
            else
            {
                ViewBag.errMessege = "not find event";
                return View("error");
            }

        }

        //Get

        [HttpGet]
        [Route("error")]
        public IActionResult Error()
        {
            return View("error");
        }


        // Delete event
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            otherPartnerService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
