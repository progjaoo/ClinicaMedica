namespace ClinicaMedica.Application.ViewModels
{
    public class MedicosViewModel
    {
        public MedicosViewModel(int idMedico, string nome, string crm, string especialidade)
        {
            IdMedico = idMedico;
            Nome = nome;
            Crm = crm;
            Especialidade = especialidade;
        }
        public int IdMedico { get; private set; }
        public string Nome { get; private set; }
        public string Crm { get; private set; }
        public string Especialidade { get; private set; }
    }
}
