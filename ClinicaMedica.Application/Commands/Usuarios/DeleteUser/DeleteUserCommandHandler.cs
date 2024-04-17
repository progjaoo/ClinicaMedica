using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public DeleteUserCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetById(request.IdUsuario);

            await _usuarioRepository.Delete(usuario.IdUsuario);
            await _usuarioRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
