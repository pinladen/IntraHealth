using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/noitification")]
    public class NoitificationController : Controller
    {
        private NotificationService notificationService;
        public NoitificationController(NotificationService _notificationService)
        {
            notificationService = _notificationService;
        }

        // GET : ALL list
        [Route("list")]
        public IActionResult List()
        {
           
            if (notificationService.FindAll() != null)
            {
                ViewBag.ev = notificationService.FindAll();
            }
            else
            {
                ViewBag.err = "no data";
            }

            return View("list");
        }

        // GET : Create 
        [HttpGet]
        [Route("send/{id}")]
        public IActionResult Send(int id)
        {
            Debug.WriteLine("id user :" + id);
            ViewBag.iduser = id;
            return View("send", new NotificationN());
        }
        // Post : Create
        [HttpPost]
        [Route("sends")]
        public IActionResult Sends(NotificationN notification)
        {
            notification.StatusNotification = true;
            notification.SendTimeNotification = DateTime.Now;
            notificationService.Create(notification);
            return RedirectToAction("list");
        }


        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("Update", notificationService.Find(id));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(NotificationN notification)
        {

            notificationService.Update(notification);
            return RedirectToAction("list");
        }

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var contract = notificationService.Find(id);
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
            notificationService.Delete(id);
            return RedirectToAction("list");
        }
    }
}
