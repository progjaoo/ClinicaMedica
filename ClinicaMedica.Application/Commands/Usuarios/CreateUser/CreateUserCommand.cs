using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Papel { get; set; }
    }
}
