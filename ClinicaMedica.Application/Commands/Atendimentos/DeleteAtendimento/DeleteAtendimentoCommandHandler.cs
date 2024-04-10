using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Atendimentos.DeleteAtendimento
{
    public class DeleteAtendimentoCommandHandler : IRequestHandler<DeleteAtendimentoCommand, Unit>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        public DeleteAtendimentoCommandHandler(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }
        public async Task<Unit> Handle(DeleteAtendimentoCommand request, CancellationToken cancellationToken)
        {
            var atendimento = await _atendimentoRepository.GetById(request.IdAtendimento);

            await _atendimentoRepository.DeleteAsync(atendimento.IdAtendimento);
            await _atendimentoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
