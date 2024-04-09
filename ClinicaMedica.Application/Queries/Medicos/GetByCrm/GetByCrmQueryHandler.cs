using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetByCrm
{
    public class GetByCrmQueryHandler : IRequestHandler<GetByCrmQuery, MedicoDetalheViewModel>
    {
        private readonly IMedicoRepository _medicoRepository;
        public GetByCrmQueryHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<MedicoDetalheViewModel> Handle(GetByCrmQuery request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetByCrm(request.Crm);

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
