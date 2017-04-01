using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBook.Models
{
    public class EventModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int GuestCount { get; set; }
        public TimeSpan Time { get; set; }
        public string Location { get; set; }
    }
}