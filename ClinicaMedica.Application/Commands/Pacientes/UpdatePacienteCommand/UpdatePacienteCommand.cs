using MediatR;

namespace ClinicaMedica.Application.Commands.Pacientes.UpdatePacienteCommand
{
    public class UpdatePacienteCommand : IRequest<Unit>
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNasc { get; set; }
        public string TipoSanguineo { get; set; }
    }
}
