using ClinicaMedica.Application.Commands.Anexos.CreateAnexoCommand;
using ClinicaMedica.Application.Commands.Anexos.DeleteAnexoCommand;
using ClinicaMedica.Application.Commands.Anexos.UpdateAnexoCommand;
using ClinicaMedica.Application.Queries.Anexos.GetAll;
using ClinicaMedica.Application.Queries.Anexos.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/anexos")]
    [ApiController]
    public class AnexosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnexosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllAnexosQuery();

            await _mediator.Send(query);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var queryId = new GetAnexoByIdQuery(id);

            if (queryId == null)
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(queryId);
            return Ok(resultado);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAnexoCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateAnexoCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteAnexoCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
