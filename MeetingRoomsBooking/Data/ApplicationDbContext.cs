using MeetingRoomsBooking.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomsBooking.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Assistant> Assistants { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Room> Rooms { get; set; }

    }
}
