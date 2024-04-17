using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.DeleteAnexoCommand
{
    public class DeleteAnexoCommandHandler : IRequestHandler<DeleteAnexoCommand, Unit>
    {
        private readonly IAnexoRepository _anexoRepository;
        public DeleteAnexoCommandHandler(IAnexoRepository anexoRepository)
        {
            _anexoRepository = anexoRepository;
        }
        public async Task<Unit> Handle(DeleteAnexoCommand request, CancellationToken cancellationToken)
        {
            var anexo = await _anexoRepository.GetById(request.IdAnexo);

            await _anexoRepository.DeleteAsync(anexo.IdAnexo);
            await _anexoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
