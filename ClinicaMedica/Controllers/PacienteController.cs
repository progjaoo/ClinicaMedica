using ClinicaMedica.Application.Queries.Pacientes.GetAll;
using ClinicaMedica.Core.Repositorios;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IMediator _mediator;

        public PacienteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var query = new GetAllPacientesQuery();
            var pacientes = await _mediator.Send(query);
            return View(pacientes);
        }
    }
}
