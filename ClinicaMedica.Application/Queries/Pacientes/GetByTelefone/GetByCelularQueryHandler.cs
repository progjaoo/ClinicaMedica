using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetByTelefone
{
    public class GetByCelularQueryHandler : IRequestHandler<GetByCelularQuery, PacienteDetalheViewModel>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public GetByCelularQueryHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<PacienteDetalheViewModel> Handle(GetByCelularQuery request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetByCelular(request.Celular);

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
