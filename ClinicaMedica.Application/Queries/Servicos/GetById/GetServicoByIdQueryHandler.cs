using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Servicos.GetById
{
    public class GetServicoByIdQueryHandler : IRequestHandler<GetServicoByIdQuery, ServicosViewModel>
    {
        private readonly IServicosRepository _servicosRepository;
        public GetServicoByIdQueryHandler(IServicosRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public async Task<ServicosViewModel> Handle(GetServicoByIdQuery request, CancellationToken cancellationToken)
        {
            var servico = await _servicosRepository.GetById(request.IdServico);

            if (servico == null) return null;

            var servicoViewModel = new ServicosViewModel(
                servico.IdServico,
                servico.NomeServico,
                servico.Descricao,
                servico.Preco,
                servico.Duracao);

            return servicoViewModel;
        }
    }
}
