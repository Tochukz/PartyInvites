//using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting =  hour > 12 ? "Good Afternoon" : "Good Morning";
            ViewData["Message"] = "Good Morning";
            return View("MyView");
            
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //There is a validation error
                return View();
            }
            
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where( r => r.WillAttend == true));
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
