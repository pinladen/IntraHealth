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
    [Route("donate")]
    public class DonateController : Controller
    {
        private DonationService donationService;
        public DonateController(DonationService _donationService)
        {
            donationService = _donationService;
        }

        // GET : ALL list
        [Route("list")]
        public IActionResult List()
        {
            ViewBag.donate = donationService.FindAll();
            return View("list");
        }


        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var donate = donationService.FindId(id);
            if (donate != null)
            {
                return View("detail", donate);
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
            donationService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
