using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook.Data
{
    public class GuestDbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<GuestDbContext>
    {
        protected override void Seed(GuestDbContext context)
        {
            base.Seed(context);

            List<EventModel> events = new List<EventModel>();
            var event1 = new EventModel
            {
                Name = "Facebook Event",
                Date = DateTime.Parse("2017-01-24"),
                GuestCount = 20,
                Location = "CCHub Yaba",
                Time = TimeSpan.FromHours(18)
            };
            events.Add(event1);

            var event2 = new EventModel
            {
                Name = "Vamia Launch",
                Date = DateTime.Parse("2017-04-01"),
                GuestCount = 100,
                Location = "Eko Hotels & Suites",
                Time = TimeSpan.FromHours(14)
            };
            events.Add(event2);

            var event3 = new EventModel
            {
                Name = "Birthday Party",
                Date = DateTime.Parse("2017-04-07"),
                GuestCount = 100,
                Location = "Eko Hotels & Suites",
                Time = TimeSpan.FromHours(14)
            };
            events.Add(event3);

            //save data into db
            foreach (var e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();
        }
    }
}