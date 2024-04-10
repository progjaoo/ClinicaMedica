using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.DeleteServico
{
    public class DeleteServicoCommand : IRequest<Unit>
    {
        public DeleteServicoCommand(int idServico)
        {
            IdServico = idServico;
        }
        public int IdServico { get; set; }
    }
}
