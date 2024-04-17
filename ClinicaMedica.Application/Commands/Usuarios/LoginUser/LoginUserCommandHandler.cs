using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Usuarios.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IAuthService _authService;
        public LoginUserCommandHandler(IUsuarioRepository usuarioRepository, IAuthService authService)
        {
            _usuarioRepository = usuarioRepository;
            _authService = authService;
        }
        ///comentários apenas para fins didáticos pessoal!
        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            //cria hash da senha com o 256Sha
            var senhaHash = _authService.ComputeSha256Hash(request.Senha);
            //busca no banco o usuario hehe
            var usuario = await _usuarioRepository.GetByEmailByPassword(request.Email, senhaHash);

            if (usuario == null) return null;
            //gera o token usando os dados do cara
            var token = _authService.GenerateJwtToken(usuario.Email, usuario.Papel);

            return new LoginUserViewModel(usuario.Email, token);
        }
    }
}
