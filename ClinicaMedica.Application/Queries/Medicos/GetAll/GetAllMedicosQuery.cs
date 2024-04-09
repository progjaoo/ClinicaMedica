using ClinicaMedica.Application.ViewModels;
using MediatR;

namespace ClinicaMedica.Application.Queries.Medico.GetAll
{
    public class GetAllMedicosQuery : IRequest<List<MedicosViewModel>> { }
}
