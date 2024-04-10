using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Servicos.GetById
{
    public class GetServicoByIdQuery : IRequest<ServicosViewModel>
    {
        public GetServicoByIdQuery(int idServico)
        {
            IdServico = idServico;
        }
        public int IdServico { get; set; }
    }
}
