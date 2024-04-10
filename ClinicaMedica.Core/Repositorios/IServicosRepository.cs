using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IServicosRepository
    {
        Task<List<Servico>> GetAll();
        Task<Servico> GetById(int id);
        Task AddAsync(Servico atendimento);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
