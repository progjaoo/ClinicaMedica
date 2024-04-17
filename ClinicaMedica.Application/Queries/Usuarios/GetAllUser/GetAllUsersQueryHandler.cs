using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Queries.Usuarios.GetAllUser
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UsuarioViewModel>>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public GetAllUsersQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<List<UsuarioViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetAllUsers();

            var usuarioViewModel = usuario.Select(u => new UsuarioViewModel(
                u.Nome,
                u.Email,
                u.Papel)).ToList();

            return usuarioViewModel;
        }
    }
}
