using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/contract")]
    public class ContractController : Controller
    {
        private ContractUsService contractUsService;
        public ContractController(ContractUsService _contractUsService)
        {
            contractUsService = _contractUsService;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("index", new ContractUsN());
        }

        [Route("send")]
        [HttpPost]
        public IActionResult Send(ContractUsN contractUs)
        {
            Debug.WriteLine("id :" + HttpContext.Session.GetInt32("idUser"));
            if (HttpContext.Session.GetInt32("idUser") != null)
            {
                contractUs.DateCreate = DateTime.Now;
                contractUs.IdUser = HttpContext.Session.GetInt32("idUser");
                contractUsService.Create(contractUs);
                return RedirectToAction("index","home", new { area = "user" });
            }
            else
            {
                return RedirectToAction("index");
            }
           
           
        }
    }
}
