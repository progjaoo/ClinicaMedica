using ClinicaMedica.Core.Enums;

namespace ClinicaMedica.Application.ViewModels
{
    public class AtendimentoViewModel 
    {
        public AtendimentoViewModel(int idServico, int idMedico, int idPaciente, TipoAtendimento tipoAtendimento)
        {
            IdServico = idServico;
            IdMedico = idMedico;
            IdPaciente = idPaciente;
            TipoAtendimento = tipoAtendimento;
        }
        public int IdServico { get;  set; }
        public int IdMedico { get;  set; }
        public int IdPaciente { get;  set; }
        public TipoAtendimento TipoAtendimento { get;  set; }
    }
}
