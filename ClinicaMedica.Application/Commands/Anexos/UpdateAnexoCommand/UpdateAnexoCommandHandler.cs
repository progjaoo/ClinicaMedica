using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.UpdateAnexoCommand
{
    public class UpdateAnexoCommandHandler : IRequestHandler<UpdateAnexoCommand, Unit>
    {
        private readonly IAnexoRepository _anexoRepository;
        public UpdateAnexoCommandHandler(IAnexoRepository anexoRepository)
        {
            _anexoRepository = anexoRepository;
        }
        public async Task<Unit> Handle(UpdateAnexoCommand request, CancellationToken cancellationToken)
        {
            var anexo = await _anexoRepository.GetById(request.IdAnexo);

            anexo.Update(request.TipoAnexo, request.NomeArquivo, request.Arquivo);

            await _anexoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
