using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Anexos.GetAll
{
    public class GetAllAnexosQueryHandler : IRequestHandler<GetAllAnexosQuery, List<AnexoViewModel>>
    {
        private readonly IAnexoRepository _anexoRepository;
        public GetAllAnexosQueryHandler(IAnexoRepository anexoRepository)
        {
            _anexoRepository = anexoRepository;
        }
        public async Task<List<AnexoViewModel>> Handle(GetAllAnexosQuery request, CancellationToken cancellationToken)
        {
            var anexo = await _anexoRepository.GetAll();

            var anexoViewModel = anexo.Select(a => new AnexoViewModel(
                a.TipoAnexo,
                a.NomeArquivo,
                a.Arquivo)).ToList();

            return anexoViewModel;
        }
    }
}
