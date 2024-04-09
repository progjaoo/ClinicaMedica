using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Medicos.UpdateMedico
{
    public class UpdateMedicoCommandHandler : IRequestHandler<UpdateMedicoCommand, Unit>
    {
        private readonly IMedicoRepository _medicoRepository;
        public UpdateMedicoCommandHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<Unit> Handle(UpdateMedicoCommand request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetById(request.IdMedico);

            medico.Update(request.Nome, request.Crm, request.Especialidade, request.Email, request.Celular, request.Endereco);

            await _medicoRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
