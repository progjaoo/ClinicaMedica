using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Servicos.GetAll
{
    public class GetAllServicosQueryHandler : IRequestHandler<GetAllServicosQuery, List<ServicosViewModel>>
    {
        private readonly IServicosRepository _servicosRepository;
        public GetAllServicosQueryHandler(IServicosRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public async Task<List<ServicosViewModel>> Handle(GetAllServicosQuery request, CancellationToken cancellationToken)
        {
            var servico = await _servicosRepository.GetAll();

            var servicoViewModel = servico.Select(s => new ServicosViewModel(
                s.NomeServico,
                s.Descricao,
                s.Preco,
                s.Duracao)).ToList();

            return servicoViewModel;
        }
    }
}
