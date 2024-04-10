using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Anexos.GetById
{
    public class GetAnexoByIdQuery : IRequest<AnexoViewModel>
    {
        public GetAnexoByIdQuery(int idAnexo)
        {
            IdAnexo = idAnexo;
        }
        public int IdAnexo {  get; set; }
    }
}
