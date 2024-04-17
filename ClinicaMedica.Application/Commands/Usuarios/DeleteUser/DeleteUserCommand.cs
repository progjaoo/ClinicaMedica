using ClinicaMedica.Core.Entidades;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.DeleteUser
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public DeleteUserCommand(int id)
        {
            IdUsuario = id;
        }
        public int IdUsuario { get; set; }
    }
}
