using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllUsers();
        Task<Usuario> GetById(int id);
        Task<Usuario> GetByEmail(string email);
        Task<Usuario> GetByEmailByPassword(string email, string passwordHash);
        Task SaveChangesAsync();
        Task Delete(int id);
    }
}
