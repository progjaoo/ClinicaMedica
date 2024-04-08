using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetByCpf
{
    public class GetByCpfQueryHandler : IRequestHandler<GetByCpfQuery, PacienteDetalheViewModel>
    {
        private readonly IPacienteRepository _pacienteRepository;

        public GetByCpfQueryHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public async Task<PacienteDetalheViewModel> Handle(GetByCpfQuery request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetByCpf(request.Cpf);

            if (paciente == null) return null;

            var pacienteDetalheViewModel = new PacienteDetalheViewModel(
                paciente.IdPaciente,
                paciente.Nome,
                paciente.Cpf,
                paciente.Celular,
                paciente.Email,
                paciente.Endereco,
                paciente.DataNasc,
                paciente.DataCadastro,
                paciente.TipoSanguineo);

            return pacienteDetalheViewModel;
        }
    }
}
