using ClinicaMedica.Application.Commands.Servicos.CreateServico;
using ClinicaMedica.Application.Commands.Servicos.DeleteServico;
using ClinicaMedica.Application.Commands.Servicos.UpdateServico;
using ClinicaMedica.Application.Queries.Servicos.GetAll;
using ClinicaMedica.Application.Queries.Servicos.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/servicos")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServicosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllServicosQuery();

            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetServicoByIdQuery(id);

            if (query == null)
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateServicoCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateServicoCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteServicoCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
