using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetById
{
    public class GetByIdPacientesQuery : IRequest<PacienteDetalheViewModel>
    {

        public GetByIdPacientesQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
