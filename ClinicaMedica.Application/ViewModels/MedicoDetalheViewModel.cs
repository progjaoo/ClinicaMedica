using MediatR;

namespace ClinicaMedica.Application.ViewModels
{
    public class MedicoDetalheViewModel 
    {
        public MedicoDetalheViewModel(int idMedico, string nome, string crm, string especialidade,
            string email,string celular, string endereco, DateTime? dataCadastro)
        {
            IdMedico = idMedico;
            Nome = nome;
            Crm = crm;
            Especialidade = especialidade;
            Email = email;
            Celular = celular;
            Endereco = endereco;
            DataCadastro = dataCadastro;
        }
        public int IdMedico { get;  set; }
        public string Nome { get;  set; }
        public string Crm { get;  set; }
        public string Especialidade { get;  set; }
        public string Email { get;  set; }
        public string Celular { get;  set; }
        public string Endereco { get;  set; }
        public DateTime? DataCadastro { get;  set; }
    }
}
