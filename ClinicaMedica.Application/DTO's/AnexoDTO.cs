using ClinicaMedica.Core.Enums;

namespace ClinicaMedica.Application.DTO_s
{
    public class AnexoDTO
    {
        public TipoAnexo TipoAnexo { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
