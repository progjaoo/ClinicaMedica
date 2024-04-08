using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IMedicoRepository 
    {
        Task<List<Medico>> GetAll();
        Task<Medico> GetById(int id);
        Task<Medico> GetByCrm(string crm);
        Task<Medico> GetByEspecialide(string especialidade);
        Task AddAsync(Medico medico);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
