using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.Admin.Controllers
{

    [Area("admin")]
    [Route("admin/event")]
    public class EventController : Controller
    {
        private EventService eventService;
        private IWebHostEnvironment webHostEnvironment;
        public EventController(EventService _eventService,IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
            eventService = _eventService;
        }

        // GET : ALL list
        [Route("list")]
        public IActionResult List()
        {
            ViewBag.ev = eventService.FindAll();
            return View("list");
        }

        // GET : Create 
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new EventN());
        }
        // Post : Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(EventN eventN , IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "user/assets/images/events", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                eventN.PhotoEvent = fileName + "." + ext;
                Debug.WriteLine("filename" + fileName);
                Debug.WriteLine("evet image" + eventN.PhotoEvent);

            }
            else
            {
                Debug.WriteLine("filename khong ton tai");

                eventN.PhotoEvent = "donate.png";
            }
            
           
            eventService.Create(eventN);
            return RedirectToAction("list");
        }


        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            var evet = eventService.Find(id);
            Debug.WriteLine("image :" + evet.PhotoEvent);
            ViewBag.image = evet.PhotoEvent;
            return View("Update",eventService.Find(id));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(EventN eventN, IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "user/assets/images/events", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                eventN.PhotoEvent = fileName + "." + ext;
            }
            eventService.Update(eventN);
            return RedirectToAction("list");
        }

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var events = eventService.Find(id);
            if(events != null)
            {
                ViewBag.photo = events.PhotoEvent;
                return View("detail",events);
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
            eventService.Delete(id);
            return RedirectToAction("list");
        }

       
    }
}
