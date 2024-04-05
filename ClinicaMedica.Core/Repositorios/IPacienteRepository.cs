using ClinicaMedica.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Core.Repositorios
{
    public interface IPacienteRepository
    {
        Task<List<Paciente>> GetAll();
        Task<Paciente> GetById(int id);
        Task<Paciente> GetByCpf(string cpf);
        Task<Paciente> GetByCelular(string celular);
        Task AddAsync(Paciente paciente);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
