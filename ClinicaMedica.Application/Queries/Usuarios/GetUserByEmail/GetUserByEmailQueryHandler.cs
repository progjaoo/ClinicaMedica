using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Usuarios.GetUserByEmail
{
    public class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, UsuarioViewModel>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public GetUserByEmailQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<UsuarioViewModel> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetByEmail(request.Email);

            var usuarioViewModel = new UsuarioViewModel(
                usuario.Nome,
                usuario.Email,
                usuario.Papel);

            return usuarioViewModel;
        }
    }
}
