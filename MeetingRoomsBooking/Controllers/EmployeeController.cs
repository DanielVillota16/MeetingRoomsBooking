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
    public class EmployeeController : CustomControllerBase<Employee>
    {
        private const string getEmployeeRouteName = "getEmployee";

        public EmployeeController(IEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        /// <summary>
        /// Permite obtener todos los cursos.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> Get()
        {
            return await Get<EmployeeDto>();
        }

        /// <summary>
        /// Permite obtener un curso por su Id.
        /// </summary>
        [HttpGet("{id:int}", Name = getEmployeeRouteName)]
        public async Task<ActionResult<EmployeeDto>> Get(int id)
        {
            return await Get<EmployeeDto>(id);
        }

        /// <summary>
        /// Permite crear un curso.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> Post([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            return await Post<CreateEmployeeDto, EmployeeDto>(createEmployeeDto, getEmployeeRouteName);
        }

        /// <summary>
        /// Permite actualizar un curso.
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateEmployeeDto updateEmployeeDto)
        {
            return await Put<UpdateEmployeeDto>(updateEmployeeDto);
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
