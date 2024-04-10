using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Anexos.GetAll
{
    public class GetAllAnexosQuery : IRequest<List<AnexoViewModel>> { }
}
