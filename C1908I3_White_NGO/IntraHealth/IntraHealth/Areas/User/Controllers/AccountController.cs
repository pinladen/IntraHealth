using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/account")]
    public class AccountController : Controller
    {
        private UserService userService;
        private DonationService donationService;
        private NotificationService notificationService;
        private IWebHostEnvironment webHostEnvironment;
        public AccountController(UserService _userService, DonationService _donationService, NotificationService _notificationService, IWebHostEnvironment _webHostEnvironment)
        {
            userService = _userService;
            donationService = _donationService;
            notificationService = _notificationService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            int user = (int)HttpContext.Session.GetInt32("idUser");
            ViewBag.donate = donationService.FindUser(user);
            ViewBag.noiti = notificationService.FindUser(user);
            ViewBag.profile = userService.Find(HttpContext.Session.GetString("username"));
            return View();
        }


        [HttpGet]
        [Route("update")]
        public IActionResult Update()
        {
            return View("Update", userService.Find((int)HttpContext.Session.GetInt32("idUser")));
        }
        // POST : Update
        [HttpPost]
        [Route("updates")]
        public IActionResult Updates(AccountN account, IFormFile file)
        {
            if (file != null)
            {
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images/avatar", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                account.AvatarUser = fileName + "." + ext;
               
            }
            userService.Update(account);
            HttpContext.Session.SetString("avatar", account.AvatarUser);
            return RedirectToAction("index");
        }
    }
}