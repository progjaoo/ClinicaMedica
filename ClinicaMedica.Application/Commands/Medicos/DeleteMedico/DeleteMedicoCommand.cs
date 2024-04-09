using MediatR;

namespace ClinicaMedica.Application.Commands.Medicos.DeleteMedico
{
    public class DeleteMedicoCommand : IRequest<Unit>
    {
        public DeleteMedicoCommand(int idMedico)
        {
            IdMedico = idMedico;
        }
        public int IdMedico { get; set; }
    }
}
