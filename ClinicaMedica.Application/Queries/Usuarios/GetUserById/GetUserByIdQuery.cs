using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Usuarios.GetUserById
{
    public class GetUserByIdQuery : IRequest<UsuarioViewModel>
    {
        public GetUserByIdQuery(int idUsuario)
        {
            IdUsuario = idUsuario;
        }
        public int IdUsuario {  get; set; }
    }
}
