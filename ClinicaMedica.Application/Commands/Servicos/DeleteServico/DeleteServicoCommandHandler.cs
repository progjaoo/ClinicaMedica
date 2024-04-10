using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.DeleteServico
{
    public class DeleteServicoCommandHandler : IRequestHandler<DeleteServicoCommand, Unit>
    {
        private readonly IServicosRepository _servicosRepository;
        public DeleteServicoCommandHandler(IServicosRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public async Task<Unit> Handle(DeleteServicoCommand request, CancellationToken cancellationToken)
        {
            var servico = await _servicosRepository.GetById(request.IdServico);

            await _servicosRepository.DeleteAsync(servico.IdServico);
            await _servicosRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
