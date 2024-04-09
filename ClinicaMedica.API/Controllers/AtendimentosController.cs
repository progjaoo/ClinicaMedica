using ClinicaMedica.Application.Queries.Atendimento.GetAll;
using ClinicaMedica.Application.Queries.Atendimento.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/atendimento")]
    [ApiController]
    public class AtendimentosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AtendimentosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllAtendimentosQuery();

            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetAtendimentoByIdQuery(id);

            if (query == null)
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
    }
}
