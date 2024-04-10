using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Atendimentos.UpdateAtendimento
{
    public class UpdateAtendimentoCommandHandler : IRequestHandler<UpdateAtendimentoCommand, Unit>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        public UpdateAtendimentoCommandHandler(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }
        public async Task<Unit> Handle(UpdateAtendimentoCommand request, CancellationToken cancellationToken)
        {
            var atendimento = await _atendimentoRepository.GetById(request.IdAtendimento);

            atendimento.Update(request.IdAtendimento, request.IdServico, request.IdPaciente, request.TipoAtendimento, request.DataInicio, request.DataFim);

            await _atendimentoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
