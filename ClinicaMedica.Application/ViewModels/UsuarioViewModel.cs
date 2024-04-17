namespace ClinicaMedica.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nome, string email,string papel)
        {
            Nome = nome;
            Email = email;
            Papel = papel;
        }
        public UsuarioViewModel(int idUsuario, string nome, string email, string senha, string papel)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            Senha = senha;
            Papel = papel;
        }
        public int IdUsuario { get;  set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Papel { get; set; }
    }
}
