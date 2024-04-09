using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetById
{
    public class GetMedicoByIdQueryHandler : IRequestHandler<GetMedicoByIdQuery, MedicoDetalheViewModel>
    {
        private readonly IMedicoRepository _medicoRepository;
        public GetMedicoByIdQueryHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<MedicoDetalheViewModel> Handle(GetMedicoByIdQuery request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetById(request.IdMedico);

            if (medico == null) return null;

            var medicoDetalheViewModel = new MedicoDetalheViewModel(
                medico.IdMedico,
                medico.Nome,
                medico.Crm,
                medico.Especialidade,
                medico.Email,
                medico.Celular,
                medico.Endereco,
                medico.DataCadastro);

            return medicoDetalheViewModel;
        }
    }
}
