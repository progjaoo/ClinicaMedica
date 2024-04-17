using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Usuarios.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UsuarioViewModel>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public GetUserByIdQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<UsuarioViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetById(request.IdUsuario);

            var usuarioViewModel = new UsuarioViewModel(
                    usuario.Nome,
                    usuario.Email,
                    usuario.Papel);

            return usuarioViewModel;
        }
    }
}
