using ClinicaMedica.Application.Commands.Atendimento.CreateAtendimento;
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Atendimentos.CreateAtendimento
{
    public class CreateAtendimentoCommandHandler : IRequestHandler<CreateAtendimentoCommand, int>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        public CreateAtendimentoCommandHandler(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }
        public async Task<int> Handle(CreateAtendimentoCommand request, CancellationToken cancellationToken)
        {
            var atendimento = new Core.Entidades.Atendimento(request.IdServico, request.IdMedico, request.IdPaciente, request.TipoAtendimento,
                request.DataInicio, request.DataFim);

            await _atendimentoRepository.AddAsync(atendimento);
            await _atendimentoRepository.SaveChangesAsync();

            return atendimento.IdAtendimento;
        }
    }
}
