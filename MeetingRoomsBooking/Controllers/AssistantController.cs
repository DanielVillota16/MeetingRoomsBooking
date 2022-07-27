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
    public class AssistantController : CustomControllerBase<Assistant>
    {
        private const string getAssistantRouteName = "getAssistant";

        public AssistantController(IAssistantRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los cursos.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<AssistantDto>>> Get()
        {
            return await Get<AssistantDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getAssistantRouteName)]
        public async Task<ActionResult<AssistantDto>> Get(int id)
        {
            return await Get<AssistantDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<AssistantDto>> Post([FromBody] CreateAssistantDto createAssistantDto)
        {
            return await Post<CreateAssistantDto, AssistantDto>(createAssistantDto, getAssistantRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateAssistantDto updateAssistantDto)
        {
            return await Put<UpdateAssistantDto>(updateAssistantDto);
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
