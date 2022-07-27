using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomsBooking.Models.Entities
{
    public class Room : IHasId
    {
        public int Id { get; set; }

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
