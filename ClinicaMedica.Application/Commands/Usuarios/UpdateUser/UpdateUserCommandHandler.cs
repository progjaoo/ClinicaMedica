using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UpdateUserCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetById(request.IdUsuario);

            usuario.Update(request.Nome, request.Email);

            await _usuarioRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
