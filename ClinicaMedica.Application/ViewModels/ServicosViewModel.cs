namespace ClinicaMedica.Application.ViewModels
{
    public class ServicosViewModel
    {
        public ServicosViewModel(
            string nomeServico, 
            string descricao, 
            decimal? preco, string duracao)
        {
            NomeServico = nomeServico;
            Descricao = descricao;
            Preco = preco;
            Duracao = duracao;
        }
        public ServicosViewModel(int idServico, 
            string nomeServico, 
            string descricao, decimal? preco, 
            string duracao)
        {
            IdServico = idServico;
            NomeServico = nomeServico;
            Descricao = descricao;
            Preco = preco;
            Duracao = duracao;
        }
        public int IdServico { get; set; }
        public string NomeServico { get;  set; }
        public string Descricao { get;  set; }
        public decimal? Preco { get;  set; }
        public string Duracao { get;  set; }
    }
}
