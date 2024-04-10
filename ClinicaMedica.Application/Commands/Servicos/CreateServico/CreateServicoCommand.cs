using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.CreateServico
{
    public class CreateServicoCommand : IRequest<int>
    {
        public string NomeServico { get;  set; }
        public string Descricao { get;  set; }
        public decimal? Preco { get;  set; }
        public string Duracao { get;  set; }
    }
}