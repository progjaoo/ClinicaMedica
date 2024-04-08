using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetByTelefone
{
    public class GetByCelularQuery : IRequest<PacienteDetalheViewModel>
    {
        public GetByCelularQuery(string celular)
        {
            Celular = celular;
        }
        public string Celular { get; set; }
    }
}
