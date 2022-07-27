using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoomsBooking.Models.Entities
{
    [Table("SALA")]
    public class Room : IHasId
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NOMBRE")]
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Column("DESCRIPCION")]
        [MaxLength(300)]
        public string? Description { get; set; }

        [Column("CAPACIDAD")]
        [Required]
        public int Capacity { get; set; }

        [Column("HABILITADA")]
        [Required]
        public bool Available { get; set; }

    }
}
