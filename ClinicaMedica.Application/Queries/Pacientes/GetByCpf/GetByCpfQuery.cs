using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Pacientes.GetByCpf
{
    public class GetByCpfQuery : IRequest<PacienteDetalheViewModel>
    {
        public GetByCpfQuery(string cpf)
        {
            Cpf = cpf;
        }
        public string Cpf { get; set; }
    }
}
