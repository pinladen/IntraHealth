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

namespace IntraHealth.Controllers
{
    [Area("admin")]
    [Route("admin/account")]
    public class AccountController : Controller
    {
        private UserService userService;
        private IWebHostEnvironment webHostEnvironment;
        public AccountController(UserService _userService ,IWebHostEnvironment _webHostEnvironment)
        {
            userService = _userService;
            webHostEnvironment = _webHostEnvironment;
        }

        // GET : ALL list
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.users = userService.FindAll();
            return View("Index");
        }

        // GET : Create 
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View("Create", new AccountN());
        }
        // Post : Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(AccountN account , IFormFile file)
        {
            var usertes= userService.Find(account.UsernameUser);
            if (usertes == null)
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
                else
                {
                    account.AvatarUser = "no-user1.png";
                }
                userService.Create(account);
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.err = "user da ton tai";
                return View("Create", new AccountN());
            }
            
        }

        // GET : Update
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            ViewBag.avatar = userService.Find(id).AvatarUser;
            return View("Update", userService.Find(id));
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

        // GET : Detail
        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var account = userService.Find(id);
            if (account != null)
            {
                ViewBag.avatar = account.AvatarUser;
                return View("detail", account);
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
            userService.Delete(id);
            return RedirectToAction("index");
        }
    }
}
