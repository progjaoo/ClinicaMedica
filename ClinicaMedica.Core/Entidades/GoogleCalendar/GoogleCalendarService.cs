namespace ClinicaMedica.Core.Entidades.GoogleCalendar
{
    public class GoogleCalendarService
    {
        public GoogleCalendarService(string resumo, string descricao, string localizacao, DateTime dataInicio, DateTime dataFim)
        {
            Resumo = resumo;
            Descricao = descricao;
            Localizacao = localizacao;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
        public string Resumo { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataInicio{ get; set; }
        public DateTime DataFim { get; set; }
    }
}
