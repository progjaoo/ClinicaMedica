using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IAtendimentoRepository
    {
        Task<List<Atendimento>> GetAll(); 
        Task<Atendimento> GetById(int id);
        Task AddAsync(Atendimento atendimento);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
