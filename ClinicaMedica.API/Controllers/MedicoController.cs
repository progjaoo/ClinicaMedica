using ClinicaMedica.Application.Commands.Medico.CreateMedico;
using ClinicaMedica.Application.Commands.Medicos.DeleteMedico;
using ClinicaMedica.Application.Commands.Medicos.UpdateMedico;
using ClinicaMedica.Application.Queries.Medico.GetAll;
using ClinicaMedica.Application.Queries.Medico.GetByCrm;
using ClinicaMedica.Application.Queries.Medico.GetByEspecialidade;
using ClinicaMedica.Application.Queries.Medico.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/medico")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MedicoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllMedicosQuery();

            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetMedicoByIdQuery(id);

            if(query == null) 
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }
        [HttpGet("GetByCrm")]
        public async Task<IActionResult> GetByCrm(string crm)
        {
            var query = new GetByCrmQuery(crm);

            if (query == null)
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }

        [HttpGet("GetByEspecialidade")]
        public async Task<IActionResult> GetByEspecialidade(string especialidade)
        {
            var query = new GetByEspecialidadeQuery(especialidade);

            if (query == null)
            {
                return BadRequest();
            }
            var resultado = await _mediator.Send(query);

            return Ok(resultado);
        }

        [HttpPost("CriarMedico")]
        public async Task<IActionResult> Post([FromBody] CreateMedicoCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateMedicoCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteMedicoCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
