using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.UpdateServico
{
    public class UpdateServicoCommand : IRequest<Unit>
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public string Duracao { get; set; }
    }
}
