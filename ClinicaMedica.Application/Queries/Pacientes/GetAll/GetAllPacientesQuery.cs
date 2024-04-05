using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Entidades;
using MediatR;
using System.Net;

namespace ClinicaMedica.Application.Queries.Pacientes.GetAll
{
    public class GetAllPacientesQuery : IRequest<List<PacientesViewModel>>
    {
        ///ignore
    }
}
