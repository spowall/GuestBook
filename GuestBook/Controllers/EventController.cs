using GuestBook.Domain;
using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuestBook.Controllers
{
    public class EventController : Controller
    {
        private EventManager _manager;

        public EventController()
        {
            _manager = new EventManager();
        }

        public ActionResult Index()
        {
            //Get All Events
            var events = _manager.ListEvents();
            return View(events);
        }

        //loads a blank event page for the user to fill
        [HttpGet] 
        public ActionResult Create()
        {
            var model = new EventModel();
            return View(model);
        }

        //performs the save event operation when a user fills the event page and clicks submit
        [HttpPost]
        public ActionResult Create(EventModel model)
        {
            if (ModelState.IsValid)
            {
                var newmodel = _manager.CreateEvent(model);
                if (newmodel != null)
                {
                    return RedirectToAction("Index");
                }
            }

            ViewBag.ErrorMessage = "Operation failed. Please check your input and try again";
            return View(model);
        }
    }
}