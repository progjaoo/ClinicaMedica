using ClinicaMedica.Application.Commands.Pacientes.CreatePacienteCommand;
using ClinicaMedica.Application.Commands.Pacientes.DeletePacienteCommand;
using ClinicaMedica.Application.Commands.Pacientes.UpdatePacienteCommand;
using ClinicaMedica.Application.Queries.Pacientes.GetAll;
using ClinicaMedica.Application.Queries.Pacientes.GetByCpf;
using ClinicaMedica.Application.Queries.Pacientes.GetById;
using ClinicaMedica.Application.Queries.Pacientes.GetByTelefone;
using ClinicaMedica.Core.Repositorios;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/pacientes")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPacienteRepository _pacienteRepository;
        public PacientesController(IMediator mediator, IPacienteRepository pacienteRepository)
        {
            _mediator = mediator;
            _pacienteRepository = pacienteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = new GetAllPacientesQuery();
                var pacientes = await _mediator.Send(query);

                return Ok(pacientes);
            }
            catch (Exception)
            {
                return StatusCode(500, $"Erro ao obter todos os pacientes!");
            }
            
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var queryId = new GetByIdPacientesQuery(id);

            try
            {
                var paciente = await _mediator.Send(queryId);

                if (paciente == null)
                {
                    return NotFound();
                }
                return Ok(paciente);
            }
            catch (Exception)
            {
                return StatusCode(500, $"Erro ao obter o paciente");
            }
        }
        [HttpGet("GetCPF")]
        public async Task<IActionResult> GetByCpf(string cpf)
        {
            var obertCpf = new GetByCpfQuery(cpf);

            try
            {
                var paciente = await _mediator.Send(obertCpf);

                if (paciente == null)
                {
                    return NotFound("CPF não existe!");
                }
                return Ok(paciente);
            }
            catch (Exception)
            {
                return StatusCode(500, $"Erro ao obter o paciente pelo seu CPF!");
            }
        }
        [HttpGet("GetTelefone")]
        public async Task<IActionResult> GetByTelefone(string celular)
        {
            var obterCell = new GetByCelularQuery(celular);

            try
            {
                var paciente = await _mediator.Send(obterCell);

                if (paciente == null)
                {
                    return NotFound("CPF não existe!");
                }
                return Ok(paciente);
            }
            catch (Exception)
            {
                return StatusCode(500, $"Erro ao obter o paciente pelo seu CPF!");
            }
        }
        [HttpPost("criarPaciente")]
        public async Task<IActionResult> Post([FromBody] CreatePacienteCommand command)
        {
            try
            {
                if (command == null)
                {
                    return BadRequest("Paciente enviado vazio!");
                }

                var id = await _mediator.Send(command);
                return CreatedAtAction(nameof(GetByIdPacientesQuery), new { id = id }, command);
            }
            catch (Exception)
            {
                return StatusCode(500, "Não foi possível adicionar o paciente!");
            }
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
