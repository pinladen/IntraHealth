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
    [Route("admin/contract")]
    public class ContractController : Controller
    {
        private ContractUsService contractUsService;
        public ContractController(ContractUsService _contractUsService)
        {
            contractUsService = _contractUsService;
        }

        // GET : ALL list
        [Route("list")]
        public IActionResult List()
        {
            ViewBag.ev = contractUsService.FindAll();
            return View("list");
        }

        // GET : Create 
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new ContractUsN());
        }
        // Post : Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(ContractUsN contractUsN)
        {
            contractUsService.Create(contractUsN);
            return RedirectToAction("list");
        }


        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("Update", contractUsService.Find(id));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(ContractUsN contractUsN)
        {

            contractUsService.Update(contractUsN);
            return RedirectToAction("list");
        }

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var contract = contractUsService.Find(id);
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
            contractUsService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
