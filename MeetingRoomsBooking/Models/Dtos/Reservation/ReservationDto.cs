using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string ReservationDate { get; set; }

        public int? ReservedById { get; set; }

        public int RoomId { get; set; }

    }
}
