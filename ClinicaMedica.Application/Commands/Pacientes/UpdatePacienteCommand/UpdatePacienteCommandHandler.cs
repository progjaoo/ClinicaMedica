using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Pacientes.UpdatePacienteCommand
{
    public class UpdatePacienteCommandHandler : IRequestHandler<UpdatePacienteCommand, Unit>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public UpdatePacienteCommandHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<Unit> Handle(UpdatePacienteCommand request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetById(request.IdPaciente);

            paciente.Update(request.Nome, request.Cpf, request.Celular, request.Email, 
                request.Endereco, request.DataNasc, request.TipoSanguineo);

            await _pacienteRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
