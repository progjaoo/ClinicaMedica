using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Entidades;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetByEspecialidade
{
    public class GetByEspecialidadeQuery : IRequest<MedicoDetalheViewModel>
    {
        public GetByEspecialidadeQuery(string especialidade)
        {
            Especialidade = especialidade;
        }
        public string Especialidade { get; set; }
    }
}
