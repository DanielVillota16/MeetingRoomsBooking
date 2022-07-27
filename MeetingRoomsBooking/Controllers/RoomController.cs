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
    public class RoomController : CustomControllerBase<Room>
    {
        private const string getRoomRouteName = "getRoom";

        public RoomController(IRoomRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los cursos.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<RoomDto>>> Get()
        {
            return await Get<RoomDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getRoomRouteName)]
        public async Task<ActionResult<RoomDto>> Get(int id)
        {
            return await Get<RoomDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<RoomDto>> Post([FromBody] CreateRoomDto createRoomDto)
        {
            return await Post<CreateRoomDto, RoomDto>(createRoomDto, getRoomRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateRoomDto updateRoomDto)
        {
            return await Put<UpdateRoomDto>(updateRoomDto);
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
