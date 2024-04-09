using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Atendimento.GetAll
{
    public class GetAllAtendimentosQuery : IRequest<List<AtendimentoViewModel>> { }
}
