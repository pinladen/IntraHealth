
using IntraHealth.Models;
using IntraHealth.Paypal;
using IntraHealth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntraHealth.Areas.User.Controllers
{
    [Area("user")]
    [Route("user/donation")]
    public class DonationController : Controller
    {
        private IConfiguration configuration;
        private EventService eventService;
        private DonationService donationService;
        public DonationController(IConfiguration _configuration, EventService _eventService ,DonationService _donationService)
        {
            configuration = _configuration;
            eventService = _eventService;
            donationService = _donationService;
    }
        [Route("index/{id}")]
        [Route("")]
        public IActionResult index(int id)
        {
            ViewBag.evt = eventService.Find(id);
            return View("index",new Card());
        }

        [HttpPost]
        [Route("card")]
        public IActionResult Card(Card card)
        {
            ViewBag.idevt = card.id;
            ViewBag.nameevt = card.nameEvent;
            ViewBag.amount = Convert.ToDecimal(card.amout.ToString("#,##0"));
            ViewBag.postURL = configuration["PayPal:PostUrl"];
            ViewBag.business = configuration["PayPal:Business"];
            ViewBag.returnUrl = configuration["PayPal:ReturnUrl"];
            return View("card");
        }
        [Route("success")]
        public IActionResult Success([FromQuery(Name = "tx")] string tx)
        {
            var result = PDTHolder.Success(tx, configuration);
            if(result != null)
            {
                Donate donate = new Donate();
                donate.IdEvent = int.Parse(result.ItemNumber);
                donate.IdUser = HttpContext.Session.GetInt32("idUser");
                donate.AmoutDonate = Convert.ToDecimal(result.GrossTotal);
                donate.StatusDonate = true;
                donate.QuantityDonate = 1;
                Debug.WriteLine("idevent :" + donate.IdEvent);
                Debug.WriteLine("idUser :" + donate.IdUser);
                Debug.WriteLine("amount :" + donate.AmoutDonate);
                Debug.WriteLine("status :" + donate.StatusDonate);
                Debug.WriteLine("quantity :" + donate.QuantityDonate);
                donationService.Create(donate);
                var evt = eventService.Find(int.Parse(result.ItemNumber));
                if (evt != null)
                {
                    decimal amount = Convert.ToDecimal(result.GrossTotal);
                    Debug.WriteLine("amout :" + amount);
                    if(evt.AmoutAchievedEvent == null)
                    {
                        evt.AmoutAchievedEvent = 0;
                        evt.AmoutAchievedEvent = evt.AmoutAchievedEvent + amount;
                        Debug.WriteLine("==============================================");
                        Debug.WriteLine("amout ace :" + evt.AmoutAchievedEvent);
                        eventService.Update(evt);
                    }
                    else
                    {
                        evt.AmoutAchievedEvent = evt.AmoutAchievedEvent + amount;
                        Debug.WriteLine("==============================================");
                        Debug.WriteLine("amout ace :" + evt.AmoutAchievedEvent);
                        eventService.Update(evt);
                    }
                   
                }
                ViewBag.ifo = " Thành công ";
                return View("Success");
            }
            else
            {
                ViewBag.ifo = "Thất bại ";
                return View("Success");
            }
            
        }
    }
}
