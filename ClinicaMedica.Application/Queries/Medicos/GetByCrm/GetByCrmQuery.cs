using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetByCrm
{
    public class GetByCrmQuery : IRequest<MedicoDetalheViewModel>
    {
        public GetByCrmQuery(string crm)
        {
            Crm = crm;
        }
        public string Crm {  get; set; }
    }
}
