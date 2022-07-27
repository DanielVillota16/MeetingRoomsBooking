using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Entities
{
    public class Assistant : IHasId
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public Reservation? Reservation { get; set; }

        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }

        [Required]
        public bool Assisted { get; set; }
    }
}
