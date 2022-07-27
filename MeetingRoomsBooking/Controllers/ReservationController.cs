using AutoMapper;
using MeetingRoomsBooking.Controllers.Base;
using MeetingRoomsBooking.Data.Repositories;
using MeetingRoomsBooking.Models.Dtos;
using MeetingRoomsBooking.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomsBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : CustomControllerBase<Reservation>
    {
        private const string getReservationRouteName = "getReservation";

        public ReservationController(IReservationRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los cursos.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<ReservationDto>>> Get()
        {
            return await Get<ReservationDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getReservationRouteName)]
        public async Task<ActionResult<ReservationDto>> Get(int id)
        {
            return await Get<ReservationDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ReservationDto>> Post([FromBody] CreateReservationDto createReservationDto)
        {
            return await Post<CreateReservationDto, ReservationDto>(createReservationDto, getReservationRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateReservationDto updateReservationDto)
        {
            return await Put<UpdateReservationDto>(updateReservationDto);
        }

        /// <summary>
        /// Permite eliminar un curso por Id.
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
