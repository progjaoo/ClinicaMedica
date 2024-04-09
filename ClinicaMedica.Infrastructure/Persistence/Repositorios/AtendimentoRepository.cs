using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public AtendimentoRepository(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Atendimento>> GetAll()
        {
            return await _dbcontext.Atendimentos.ToListAsync();
        }
        public async Task<Atendimento> GetById(int id)
        {
            return await _dbcontext.Atendimentos.SingleOrDefaultAsync(a => a.IdAtendimento == id);
        }
        public async Task AddAsync(Atendimento atendimento)
        {
            await _dbcontext.AddAsync(atendimento);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var atendimento = await _dbcontext.Atendimentos.FindAsync(id);
            _dbcontext.Atendimentos.Remove(atendimento);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
