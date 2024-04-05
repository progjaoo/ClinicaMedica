namespace ClinicaMedica.Application.ViewModels
{
    public class PacienteDetalheViewModel
    {
        public PacienteDetalheViewModel(int idPaciente, string nome, string cpf, string celular, string email,
            string endereco, DateTime? dataNasc, DateTime? dataCadastro, string tipoSanguineo)
        {
            IdPaciente = idPaciente;
            Nome = nome;
            Cpf = cpf;
            Celular = celular;
            Email = email;
            Endereco = endereco;
            DataNasc = dataNasc;
            DataCadastro = dataCadastro;
            TipoSanguineo = tipoSanguineo;
        }

        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNasc { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string TipoSanguineo { get; set; }
    }
}
