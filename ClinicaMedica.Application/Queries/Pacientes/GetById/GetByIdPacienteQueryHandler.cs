using ClinicaMedica.Application.ViewModels;
using ClinicaMedica.Core.Repositorios;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Application.Queries.Pacientes.GetById
{
    public class GetByIdPacienteQueryHandler : IRequestHandler<GetByIdPacientesQuery, PacienteDetalheViewModel>
    {
        private readonly IPacienteRepository _pacienteRepository;
        public GetByIdPacienteQueryHandler(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        public async Task<PacienteDetalheViewModel> Handle(GetByIdPacientesQuery request, CancellationToken cancellationToken)
        {
            var paciente = await _pacienteRepository.GetById(request.Id);

            if (paciente == null) return null;

            var pacienteDetalheViewModel = new PacienteDetalheViewModel(
                paciente.IdPaciente,
                paciente.Nome,
                paciente.Cpf,
                paciente.Celular,
                paciente.Email,
                paciente.Endereco,
                paciente.DataNasc,
                paciente.DataCadastro,
                paciente.TipoSanguineo);

            return pacienteDetalheViewModel;
        }
    }
}
