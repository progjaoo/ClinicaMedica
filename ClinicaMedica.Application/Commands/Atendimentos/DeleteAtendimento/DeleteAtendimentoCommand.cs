using MediatR;

namespace ClinicaMedica.Application.Commands.Atendimentos.DeleteAtendimento
{
    public class DeleteAtendimentoCommand : IRequest<Unit>
    {
        public DeleteAtendimentoCommand(int idAtendimento)
        {
            IdAtendimento = idAtendimento;
        }
        public int IdAtendimento { get; set; }
    }
}
