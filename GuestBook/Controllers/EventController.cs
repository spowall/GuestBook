using GuestBook.Domain;
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
    }
}