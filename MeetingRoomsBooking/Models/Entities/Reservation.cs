using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Entities
{
    public class Reservation : IHasId
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string ReservationDate { get; set; }

        public int? ReservedById { get; set; }

        public Employee? ReservedBy { get; set; }

        public int RoomId { get; set; }

        public Room? Room { get; set; }

    }
}
