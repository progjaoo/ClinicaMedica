using ClinicaMedica.Core.Enums;
using MediatR;

namespace ClinicaMedica.Application.Commands.Atendimento.CreateAtendimento
{
    public class CreateAtendimentoCommand : IRequest<int>
    {
        public int IdAtendimento { get;  set; }
        public int IdServico { get;  set; }
        public int IdMedico { get;  set; }
        public int IdPaciente { get;  set; }
        public TipoAtendimento TipoAtendimento { get;  set; }
        public DateTime? DataInicio { get;  set; }
        public DateTime? DataFim { get;  set; }
    }
}
