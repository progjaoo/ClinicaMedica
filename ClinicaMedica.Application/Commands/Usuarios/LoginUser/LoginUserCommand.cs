using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
