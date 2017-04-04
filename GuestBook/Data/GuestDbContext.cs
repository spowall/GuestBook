using GuestBook.Models;
using System.Data.Entity;

namespace GuestBook.Data
{
    public class GuestDbContext : DbContext
    {
        public DbSet<EventModel> Events { get; set; }

        public GuestDbContext() : base("GuestDbConnectionString")
        {
            var initializer = new GuestDbInitializer();
            Database.SetInitializer(initializer);
        }
    }
}