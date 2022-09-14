using IntraHealth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private UserService userService;
        public LoginController(UserService _userService)
        {
            userService = _userService;
        }
       
        
        [Route("login")]
        [Route("")]

        public IActionResult Index()
        {
            return View("login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            try
            {
                if(username !=null &&password != null)
                {
                    var account = userService.Login(username, password);
                    if (account != null)
                    {
                        if(account.StatusUser == false || account.StatusUser == null)
                        {
                            ViewBag.erro = "Your account has been locked !! ,Please contact us again  ";
                            return View("login");
                        }
                        else
                        {
                            HttpContext.Session.SetString("username", username);
                            HttpContext.Session.SetString("avatar", account.AvatarUser);
                            HttpContext.Session.SetString("date", account.TimeCreateUser.ToString());
                            HttpContext.Session.SetString("status", account.StatusUser.ToString());
                            HttpContext.Session.SetString("role", account.IdRole.ToString());
                            HttpContext.Session.SetInt32("idUser", account.IdUser);

                            if (account.IdRole == 1)
                            {
                                return RedirectToAction("index", "home", new { area = "admin" });
                            }
                            else
                            {
                                return RedirectToAction("index", "home", new { area = "user" });
                            }
                        }
                        
                    }
                    else
                    {
                        ViewBag.erro = "Can't find username and password , ";
                        return View("login");
                    }
                }
                else
                {
                    ViewBag.erro = "Please enter username and password";
                    return View("login");
                }
            }
            catch
            {
                return RedirectToAction("login");
            }
         
        }
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index", "home", new { area = "user" });
        }



    }
}
