using ClinicaMedica.Core.Enums;

namespace ClinicaMedica.Application.ViewModels
{
    public class AnexoViewModel
    {
        public AnexoViewModel(TipoAnexo tipoAnexo, string nomeArquivo, byte[] arquivo)
        {
            TipoAnexo = tipoAnexo;
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
        }
        public AnexoViewModel(int idAnexo, TipoAnexo tipoAnexo, string nomeArquivo, byte[] arquivo)
        {
            IdAnexo = idAnexo;
            TipoAnexo = tipoAnexo;
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
        }
        public int IdAnexo { get;  set; }
        public TipoAnexo TipoAnexo { get;  set; }
        public string NomeArquivo { get;  set; }
        public byte[] Arquivo { get;  set; }
    }
}
