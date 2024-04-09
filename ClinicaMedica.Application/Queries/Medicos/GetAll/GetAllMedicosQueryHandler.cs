using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetAll
{
    public class GetAllMedicosQueryHandler : IRequestHandler<GetAllMedicosQuery, List<MedicosViewModel>>
    {
        private readonly IMedicoRepository _medicoRepository;
        public GetAllMedicosQueryHandler(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public async Task<List<MedicosViewModel>> Handle(GetAllMedicosQuery request, CancellationToken cancellationToken)
        {
            var medico = await _medicoRepository.GetAll();

            var medicoViewModel = medico.Select(m => new MedicosViewModel(
               m.IdMedico, m.Nome, m.Crm, m.Especialidade)).ToList();

            return medicoViewModel;
        }
    }
}
