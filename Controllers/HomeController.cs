using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

using System;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {
        public IActionResult Index()
        {
            return View();
        }
        //The[HttpGet] attribute is used to specify that this action method should respond to HTTP GET requests.This means that the action method can only be accessed by making an HTTP GET request to the corresponding URL.
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        // Handles the form submission when a guest RSVPs to an event. It uses the HTTP POST method to send the form data to the server, and then stores the guest's response. Finally, it returns a view.
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            //  takes a GuestResponse object that is populated from RsvpForm.cshtml view as a parameter and adds it to the repository responses list using the Add method.
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}