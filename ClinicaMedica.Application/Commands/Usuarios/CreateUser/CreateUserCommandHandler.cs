using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly ClinicaMedicaContext _dbcontext;
        private readonly IAuthService _authService;
        public CreateUserCommandHandler(IAuthService authService, ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
            _authService = authService;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var senhaHash = _authService.ComputeSha256Hash(request.Senha);

            var usuario = new Usuario(request.Nome, request.Email, senhaHash, request.Papel);

            await _dbcontext.Usuarios.AddAsync(usuario);
            await _dbcontext.SaveChangesAsync();

            return usuario.IdUsuario;
        }
    }
}
