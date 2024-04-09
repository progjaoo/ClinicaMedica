using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Atendimento.GetById
{
    public class GetAtendimentoByIdQueryHandler : IRequestHandler<GetAtendimentoByIdQuery, AtendimentoDetalheViewModel>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        public GetAtendimentoByIdQueryHandler(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }
        public async Task<AtendimentoDetalheViewModel> Handle(GetAtendimentoByIdQuery request, CancellationToken cancellationToken)
        {
            var atendimento = await _atendimentoRepository.GetById(request.IdAtendimento);

            if (atendimento == null) return null;

            var atendimentoDetalheViewModel = new AtendimentoDetalheViewModel(
                atendimento.IdServico,
                atendimento.IdMedico,
                atendimento.IdPaciente,
                atendimento.TipoAtendimento,
                atendimento.DataInicio,
                atendimento.DataFim);

            return atendimentoDetalheViewModel;
        }
    }
}
