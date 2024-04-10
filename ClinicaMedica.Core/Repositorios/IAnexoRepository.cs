using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IAnexoRepository
    {
        Task<List<Anexo>> GetAll();
        Task<Anexo> GetById(int id);
        Task AddAsync (Anexo anexo);
        Task DeleteAsync (int id);
        Task SaveChangesAsync();
    }
}
