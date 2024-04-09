using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetById
{
    public class GetMedicoByIdQuery : IRequest<MedicoDetalheViewModel>
    {
        public GetMedicoByIdQuery(int idMedico)
        {
            IdMedico = idMedico;
        }
        public int IdMedico { get; set; }
    }
}
