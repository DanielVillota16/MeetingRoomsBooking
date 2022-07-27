using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Dtos
{
    public class CreateRoomDto
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public bool Available { get; set; }
    }
}
