using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class AnexoRepository : IAnexoRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public AnexoRepository(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Anexo>> GetAll()
        {
            return await _dbcontext.Anexos.ToListAsync();
        }
        public async Task<Anexo> GetById(int id)
        {
            return await _dbcontext.Anexos.SingleOrDefaultAsync(a => a.IdAnexo == id);
        }
        public async Task AddAsync(Anexo anexo)
        {
            await _dbcontext.AddAsync(anexo);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var anexo = await _dbcontext.Anexos.FindAsync(id);
            _dbcontext.Anexos.Remove(anexo);

            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
