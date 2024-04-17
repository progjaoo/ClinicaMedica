using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.UpdateUser
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Papel { get; set; }
    }
}
