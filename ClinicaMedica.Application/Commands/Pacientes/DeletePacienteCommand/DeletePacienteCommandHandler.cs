using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Pacientes.DeletePacienteCommand
{
    public class DeletePacienteCommandHandler : IRequestHandler<DeletePacienteCommand, Unit>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public DeletePacienteCommandHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<Unit> Handle(DeletePacienteCommand request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetById(request.IdPaciente);

            await _pacienteRepository.DeleteAsync(paciente.IdPaciente);
            await _pacienteRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
