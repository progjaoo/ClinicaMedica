using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Medicos.DeleteMedico
{
    public class DeleteMedicoCommandHandler : IRequestHandler<DeleteMedicoCommand, Unit>
    {
        private readonly IMedicoRepository _medicoRepository;
        public DeleteMedicoCommandHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<Unit> Handle(DeleteMedicoCommand request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetById(request.IdMedico);

            await _medicoRepository.DeleteAsync(medico.IdMedico);
            await _medicoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
