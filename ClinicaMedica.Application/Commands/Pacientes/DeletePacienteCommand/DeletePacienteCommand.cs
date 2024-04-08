using MediatR;

namespace ClinicaMedica.Application.Commands.Pacientes.DeletePacienteCommand
{
    public class DeletePacienteCommand : IRequest<Unit>
    {
        public DeletePacienteCommand(int idPaciente)
        {
            IdPaciente = idPaciente;
        }
        public int IdPaciente { get; set; }
    }
}
