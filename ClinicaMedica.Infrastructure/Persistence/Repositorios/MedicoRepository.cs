using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public MedicoRepository(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Medico>> GetAll()
        {
            return await _dbcontext.Medicos.ToListAsync();
        }
        public async Task<Medico> GetById(int id)
        {
            return await _dbcontext.Medicos.SingleOrDefaultAsync(m => m.IdMedico== id);
        }

        public async Task<Medico> GetByCrm(string crm)
        {
            return await _dbcontext.Medicos.SingleOrDefaultAsync(m => m.Crm == crm);
        }

        public async Task<Medico> GetByEspecialide(string especialidade)
        {
            return await _dbcontext.Medicos.SingleOrDefaultAsync(m => m.Especialidade == especialidade);
        }
        public async Task AddAsync(Medico medico)
        {
            await _dbcontext.AddAsync(medico);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var medico = await _dbcontext.Medicos.FindAsync(id);
            _dbcontext.Medicos.Remove(medico);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
