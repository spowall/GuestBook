using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook.Domain
{
    public class EventManager
    {
        private static List<EventModel> _events = new List<EventModel>();

        static EventManager()
        {
            var event1 = new EventModel
            {
                Name = "Facebook Event",
                Date = DateTime.Parse("2017-01-24"),
                GuestCount = 20,
                Location = "CCHub Yaba",
                Time = TimeSpan.FromHours(18)
            };

            _events.Add(event1);

            var event2 = new EventModel
            {
                Name = "Vamia Launch",
                Date = DateTime.Parse("2017-04-01"),
                GuestCount = 100,
                Location = "Eko Hotels & Suites",
                Time = TimeSpan.FromHours(14)
            };

            _events.Add(event2);
        }

        public EventModel[] ListEvents()
        {
            return _events.ToArray();
        }

        public EventModel CreateEvent(EventModel model)
        {
            _events.Add(model);
            return model;
        }

        public EventModel SearchEvent(string name)
        {
            var model = _events.Where(e => e.Name.ToLower() == name.ToLower())
                               .FirstOrDefault();
            return model;
        }
    }
}