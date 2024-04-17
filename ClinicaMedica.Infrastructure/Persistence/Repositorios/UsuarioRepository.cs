using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;

        public async Task<List<Usuario>> GetAllUsers()
        {
            return await _dbcontext.Usuarios.ToListAsync();
        }
        public async Task<Usuario> GetByEmail(string email)
        {
            return await _dbcontext.Usuarios.SingleOrDefaultAsync(u => u.Email == email);
        }
        public async Task<Usuario> GetById(int id)
        {
            return await _dbcontext.Usuarios.SingleOrDefaultAsync(u => u.IdUsuario == id);
        }
        public async Task Delete(int id)
        {
            var usuario = await _dbcontext.Usuarios.FindAsync(id);

            _dbcontext.Usuarios.Remove(usuario);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<Usuario> GetByEmailByPassword(string email, string passwordHash)
        {
            return await _dbcontext.Usuarios.SingleOrDefaultAsync(u => u.Email == email && u.Senha == passwordHash);
        }
    }
}
