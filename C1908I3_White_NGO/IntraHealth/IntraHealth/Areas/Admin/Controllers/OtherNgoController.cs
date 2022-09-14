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
    [Route("admin/otherngo")]
    public class OtherNgoController : Controller
    {

        private  OtherNgoSevice otherNgoSevice;
        public OtherNgoController(OtherNgoSevice _otherNgoSevice)
        {
            otherNgoSevice = _otherNgoSevice;
        }

        // list all event
        [Route("list")]
        public IActionResult List()
        {

            ViewBag.oth = otherNgoSevice.FindAll();
            return View("list");
        }

        // Create event
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new OtherNgo());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(OtherNgo otherNgo)
        {

            otherNgoSevice.Create(otherNgo);
            return RedirectToAction("list");
        }


        // update event
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("Update", otherNgoSevice.Find(id));
        }
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(OtherNgo otherNgo)
        {

            otherNgoSevice.Update(otherNgo);
            return RedirectToAction("list");
        }
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var oth = otherNgoSevice.Find(id);
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
            otherNgoSevice.Delete(id);
            return RedirectToAction("list");
        }
    }
}
