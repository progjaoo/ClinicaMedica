using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.UpdateServico
{
    public class UpdateServicoCommandHandler : IRequestHandler<UpdateServicoCommand, Unit>
    {
        private readonly IServicosRepository _servicosRepository;
        public UpdateServicoCommandHandler(IServicosRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public async Task<Unit> Handle(UpdateServicoCommand request, CancellationToken cancellationToken)
        {
            var servico = await _servicosRepository.GetById(request.IdServico);

            servico.Update(request.NomeServico, request.Descricao, request.Preco, request.Duracao);

            await _servicosRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
