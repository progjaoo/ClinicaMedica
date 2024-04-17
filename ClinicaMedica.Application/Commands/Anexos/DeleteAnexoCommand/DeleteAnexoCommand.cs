using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.DeleteAnexoCommand
{
    public class DeleteAnexoCommand : IRequest<Unit>
    {
        public DeleteAnexoCommand(int idAnexo)
        {
            IdAnexo = idAnexo;
        }
        public int IdAnexo { get; set; }
    }
}
