using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetAll
{
    public class GetAllPacientesQueryHandler : IRequestHandler<GetAllPacientesQuery, List<PacientesViewModel>>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public GetAllPacientesQueryHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<List<PacientesViewModel>> Handle(GetAllPacientesQuery request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetAll();

            var pacienteViewModel = paciente
                .Select(p => new PacientesViewModel(p.IdPaciente, p.Nome, p.Cpf,p.TipoSanguineo)).ToList();

            return pacienteViewModel;
        }
    }
}
