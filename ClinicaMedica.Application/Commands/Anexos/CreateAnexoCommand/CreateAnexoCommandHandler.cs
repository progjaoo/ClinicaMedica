using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.CreateAnexoCommand
{
    public class CreateAnexoCommandHandler : IRequestHandler<CreateAnexoCommand, int>
    {
        private readonly IAnexoRepository _anexoRepository;
        public CreateAnexoCommandHandler(IAnexoRepository anexoRepository)
        {
            _anexoRepository = anexoRepository;
        }
        public async Task<int> Handle(CreateAnexoCommand request, CancellationToken cancellationToken)
        {
            var anexo = new Anexo(request.TipoAnexo, request.NomeArquivo, request.Arquivo);

            await _anexoRepository.AddAsync(anexo);
            await _anexoRepository.SaveChangesAsync();

            return anexo.IdAnexo;
        }
    }
}
