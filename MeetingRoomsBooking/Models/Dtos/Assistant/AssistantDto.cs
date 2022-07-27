using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class AssistantDto
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        public bool Assisted { get; set; }
    }
}
