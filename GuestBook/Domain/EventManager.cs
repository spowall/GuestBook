using GuestBook.Data;
using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook.Domain
{
    public class EventManager
    {
        private GuestDbContext _guestdbcontext;
        private List<EventModel> _events = new List<EventModel>();       
        public EventManager()
        {
            _guestdbcontext = new GuestDbContext();
        }

        public EventModel[] ListEvents()
        {
            _events = _guestdbcontext.Events.ToList();
            return _events.ToArray();
        }

        public EventModel CreateEvent(EventModel model)
        {

            _guestdbcontext.Events.Add(model);
            _guestdbcontext.SaveChanges();
            var newmodel = _guestdbcontext.Events.FirstOrDefault(p => p.Name == model.Name);
            return newmodel;
        }

        public EventModel SearchEvent(string name)
        {
            var model = _events.Where(e => e.Name.ToLower() == name.ToLower())
                               .FirstOrDefault();
            return model;
        }
    }
}