using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Atendimento.GetById
{
    public class GetAtendimentoByIdQuery : IRequest<AtendimentoDetalheViewModel>
    {
        public GetAtendimentoByIdQuery(int idAtendimento)
        {
            IdAtendimento = idAtendimento;
        }
        public int IdAtendimento { get; set; }
    }
}
