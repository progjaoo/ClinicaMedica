using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Pacientes.CreatePacienteCommand
{
    public class CreatePacienteCommandHandler : IRequestHandler<CreatePacienteCommand, int>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public CreatePacienteCommandHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<int> Handle(CreatePacienteCommand request, CancellationToken cancellationToken)
        {
            var paciente = new Paciente(request.Nome, request.Cpf, request.Celular, request.Email, request.Endereco, request.DataNasc, request.TipoSanguineo);

            await _pacienteRepository.AddAsync(paciente);
            await _pacienteRepository.SaveChangesAsync();

            return paciente.IdPaciente;
        }
    }
}
