using ClinicaMedica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Application.Queries.Usuarios.GetAllUser
{
    public class GetAllUsersQuery : IRequest<List<UsuarioViewModel>> { }
}
