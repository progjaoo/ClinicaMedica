using ClinicaMedica.Core.Enums;
using MediatR;

namespace ClinicaMedica.Application.Commands.Anexos.CreateAnexoCommand
{
    public class CreateAnexoCommand : IRequest<int>
    {
        public TipoAnexo TipoAnexo { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
