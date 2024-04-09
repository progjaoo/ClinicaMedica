using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetByEspecialidade
{
    public class GetByEspecialidadeQueryHandler : IRequestHandler<GetByEspecialidadeQuery, MedicoDetalheViewModel>
    {
        private readonly IMedicoRepository _medicoRepository;
        public GetByEspecialidadeQueryHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<MedicoDetalheViewModel> Handle(GetByEspecialidadeQuery request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetByEspecialide(request.Especialidade);

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
