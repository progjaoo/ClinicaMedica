using ClinicaMedica.Core.Enums;

namespace ClinicaMedica.Application.ViewModels
{
    public class AtendimentoDetalheViewModel
    {
        public AtendimentoDetalheViewModel(int idServico, int idMedico, int idPaciente, TipoAtendimento tipoAtendimento,
            DateTime? dataInicio, DateTime? dataFim)
        {
            IdServico = idServico;
            IdMedico = idMedico;
            IdPaciente = idPaciente;
            TipoAtendimento = tipoAtendimento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public int IdServico { get;  set; }
        public int IdMedico { get;  set; }
        public int IdPaciente { get;  set; }
        public TipoAtendimento TipoAtendimento { get;  set; }
        public DateTime? DataInicio { get;  set; }
        public DateTime? DataFim { get;  set; }
    }
}
