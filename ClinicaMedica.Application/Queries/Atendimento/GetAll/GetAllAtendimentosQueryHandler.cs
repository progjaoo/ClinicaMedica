using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Atendimento.GetAll
{
    public class GetAllAtendimentosQueryHandler : IRequestHandler<GetAllAtendimentosQuery, List<AtendimentoViewModel>>
    {
        private readonly IAtendimentoRepository _atendimentoRepository;
        public GetAllAtendimentosQueryHandler(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }
        public async Task<List<AtendimentoViewModel>> Handle(GetAllAtendimentosQuery request, CancellationToken cancellationToken)
        {
            var atendimento = await _atendimentoRepository.GetAll();

            var atendimentoViewModel = atendimento.Select(a => new AtendimentoViewModel(
                a.IdServico,
                a.IdMedico,
                a.IdPaciente,
                a.TipoAtendimento)).ToList();

            return atendimentoViewModel;
        }
    }
}
