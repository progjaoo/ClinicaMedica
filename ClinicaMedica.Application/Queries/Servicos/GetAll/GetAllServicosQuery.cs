using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Servicos.GetAll
{
    public class GetAllServicosQuery : IRequest<List<ServicosViewModel>>
    {
        //ignore
    }
}
