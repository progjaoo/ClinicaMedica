using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Application.ViewModels
{
    public class PacientesViewModel
    {
        public PacientesViewModel(int idPaciente, string nome, string cpf, string tipoSanguineo)
        {
            IdPaciente = idPaciente;
            Nome = nome;
            Cpf = cpf;
            TipoSanguineo = tipoSanguineo;
        }

        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoSanguineo { get; set; }
    }
}
