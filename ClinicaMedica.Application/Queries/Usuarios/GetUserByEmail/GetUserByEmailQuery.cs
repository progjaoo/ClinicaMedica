using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Usuarios.GetUserByEmail
{
    public class GetUserByEmailQuery : IRequest<UsuarioViewModel>
    {
        public GetUserByEmailQuery(string email)
        {
            Email = email;
        }
        public string Email { get; set; }
    }
}
