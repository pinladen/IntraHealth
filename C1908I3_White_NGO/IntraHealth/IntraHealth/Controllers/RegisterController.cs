using IntraHealth.Models;
using IntraHealth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Controllers
{
    [Route("register")]
    public class RegisterController : Controller
    {
        private UserService userService;
        public RegisterController(UserService _userService)
        {
            userService = _userService;
        }

        
        [Route("register")]
        public IActionResult Index()
        {
            return View("register",new AccountN());
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(AccountN accountN)
        {
            if(accountN.UsernameUser != null && accountN.EmailUser !=null &&accountN.PasswordUser !=null) {
                Debug.WriteLine("username :" + accountN.UsernameUser);
                var account = userService.Find(accountN.UsernameUser);
                if (account == null)
                {
                    accountN.AvatarUser = "no-user1.png";
                    var user = userService.Create(accountN);
                    HttpContext.Session.SetString("username", user.UsernameUser);
                    HttpContext.Session.SetString("avatar", user.AvatarUser);
                    HttpContext.Session.SetString("date", user.TimeCreateUser.ToString());
                    HttpContext.Session.SetString("status", user.StatusUser.ToString());
                    HttpContext.Session.SetString("role", user.IdRole.ToString());
                    HttpContext.Session.SetInt32("idUser", user.IdUser);
                    return RedirectToAction("index", "home", new { area = "user" });
                }
                else
                {
                    ViewBag.username = "Account has been created. Please enter a new account !";
                    return View("register");
                }
            }
            else
            {
                ViewBag.username = "Please enter enough information !";
                return View("register");
            }
            
            
            
        }
    }
}
