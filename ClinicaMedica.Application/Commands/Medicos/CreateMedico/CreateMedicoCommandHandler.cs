using ClinicaMedica.Application.Commands.Medico.CreateMedico;
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Medicos.CreateMedico
{
    public class CreateMedicoCommandHandler : IRequestHandler<CreateMedicoCommand, int>
    {
        private readonly IMedicoRepository _medicoRepository;
        public CreateMedicoCommandHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<int> Handle(CreateMedicoCommand request, CancellationToken cancellationToken)
        {
            var medico = new Core.Entidades.Medico(request.Nome, request.Crm, request.Especialidade,
                request.Email, request.Celular, request.Endereco);

            await _medicoRepository.AddAsync(medico);
            await _medicoRepository.SaveChangesAsync();

            return medico.IdMedico;
        }
    }
}
