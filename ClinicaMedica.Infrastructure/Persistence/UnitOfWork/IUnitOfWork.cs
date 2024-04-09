namespace ClinicaMedica.Infrastructure.Persistence.UnitOfWork
{
    public interface IUnitOfWork 
    {
        Task<int> CommitAsync();
    }
}
