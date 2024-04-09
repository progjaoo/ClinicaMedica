using MediatR;

namespace ClinicaMedica.Application.Commands.Medico.CreateMedico
{
    public class CreateMedicoCommand : IRequest<int>
    {
        public string Nome { get;  set; }
        public string Crm { get;  set; }
        public string Especialidade { get;  set; }
        public string Email { get;  set; }
        public string Celular { get;  set; }
        public string Endereco { get;  set; }
    }
}
