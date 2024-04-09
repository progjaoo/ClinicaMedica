
using ClinicaMedica.Core.Entidades;

namespace ClinicaMedica.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicaMedicaContext _dbcontext;
        public UnitOfWork(ClinicaMedicaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> CommitAsync()
        {
            return await _dbcontext.SaveChangesAsync();
        }
    }
}
