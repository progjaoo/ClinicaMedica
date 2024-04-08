
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ClinicaMedica.Infrastructure.Persistence.Repositorios
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public PacienteRepository(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Paciente>> GetAll()
        {
            return await _dbcontext.Pacientes.ToListAsync();
        }

        public async Task<Paciente> GetById(int id)
        {
            return await _dbcontext.Pacientes.SingleOrDefaultAsync(p => p.IdPaciente == id);
        }
        public async Task<Paciente> GetByCpf(string cpf)
        {
            return await _dbcontext.Pacientes.SingleOrDefaultAsync(p => p.Cpf == cpf);

        }
        public async Task<Paciente> GetByCelular(string celular)
        {
            return await _dbcontext.Pacientes.SingleOrDefaultAsync(p => p.Celular == celular);
        }
        public async Task AddAsync(Paciente paciente)
        {
            await _dbcontext.AddAsync(paciente);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var paciente = await _dbcontext.Pacientes.FindAsync(id);
            _dbcontext.Pacientes.Remove(paciente);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();   
        }
    }
}