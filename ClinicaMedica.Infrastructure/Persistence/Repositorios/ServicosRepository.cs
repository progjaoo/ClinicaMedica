using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class ServicosRepository : IServicosRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public ServicosRepository(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Servico>> GetAll()
        {
            return await _dbcontext.Servicos.ToListAsync();
        }
        public async Task<Servico> GetById(int id)
        {
            return await _dbcontext.Servicos.SingleOrDefaultAsync(s => s.IdServico == id);
        }
        public async Task AddAsync(Servico atendimento)
        {
            await _dbcontext.AddAsync(atendimento);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var servico = await _dbcontext.Servicos.FindAsync(id);
            
            _dbcontext.Servicos.Remove(servico);

            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
