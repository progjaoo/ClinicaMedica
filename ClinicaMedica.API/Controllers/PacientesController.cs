using ClinicaMedica.Application.Commands.Pacientes.CreatePacienteCommand;
using ClinicaMedica.Application.Commands.Pacientes.DeletePacienteCommand;
using ClinicaMedica.Application.Commands.Pacientes.UpdatePacienteCommand;
using ClinicaMedica.Application.Queries.Pacientes.GetAll;
using ClinicaMedica.Application.Queries.Pacientes.GetByCpf;
using ClinicaMedica.Application.Queries.Pacientes.GetById;
using ClinicaMedica.Application.Queries.Pacientes.GetByTelefone;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PacientesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
                var query = new GetAllPacientesQuery();
                var pacientes = await _mediator.Send(query);

                return Ok(pacientes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var queryId = new GetByIdPacientesQuery(id);

                var paciente = await _mediator.Send(queryId);

                if (paciente == null)
                {
                    return NotFound();
                }
                return Ok(paciente);
        }
        [HttpGet("GetCPF")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            var query = new GetByCpfQuery(cpf);

            var paciente = await _mediator.Send(query);

                if (paciente == null)
                {
                    return NotFound("CPF não existe!");
                }
            return Ok(paciente);
        }
        [HttpGet("GetTelefone")]
        public async Task<IActionResult> GetByTelefone(string celular)
        {
            var query = new GetByCelularQuery(celular);

                var paciente = await _mediator.Send(query);

                if (paciente == null)
                {
                    return NotFound("CPF não existe!");
                }
                return Ok(paciente);
        }
        [HttpPost("criarPaciente")]
        public async Task<IActionResult> Post([FromBody] CreatePacienteCommand command)
        {
                var id = await _mediator.Send(command);
                return CreatedAtAction(nameof(GetByIdPacientesQuery), new { id = id }, command);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdatePacienteCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePacienteCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
