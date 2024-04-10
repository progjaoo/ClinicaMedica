using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Anexos.GetById
{
    public class GetAnexoByIdQueryHandler : IRequestHandler<GetAnexoByIdQuery, AnexoViewModel>
    {
        private readonly IAnexoRepository _anexoRepository;
        public GetAnexoByIdQueryHandler(IAnexoRepository anexoRepository)
        {
            _anexoRepository = anexoRepository;
        }
        public async Task<AnexoViewModel> Handle(GetAnexoByIdQuery request, CancellationToken cancellationToken)
        {
            var anexo = await _anexoRepository.GetById(request.IdAnexo);

            if (anexo == null) return null;

            var anexoViewModel = new AnexoViewModel(
                anexo.IdAnexo,
                anexo.TipoAnexo,
                anexo.NomeArquivo,
                anexo.Arquivo);

            return anexoViewModel;
        }
    }
}
