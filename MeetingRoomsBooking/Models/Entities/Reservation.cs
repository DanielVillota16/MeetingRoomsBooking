using MeetingRoomsBooking.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoomsBooking.Models.Entities
{
    [Table("RESERVA")]
    public class Reservation : IHasId
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("FECHA_HORA")]
        [Required]
        [MaxLength(80)]
        public string ReservationDate { get; set; }

        [Column("RESERVADO_POR")]
        public int ReservedById { get; set; }

        public Employee? ReservedBy { get; set; }

        [Column("SALA_ID")]
        public int RoomId { get; set; }

        public Room? Room { get; set; }

    }
}
