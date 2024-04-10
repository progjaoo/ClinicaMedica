using ClinicaMedica.Core.Enums;
using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.UpdateAnexoCommand
{
    public class UpdateAnexoCommand : IRequest<Unit>
    {
        public int IdAnexo { get; set; }
        public TipoAnexo TipoAnexo { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
