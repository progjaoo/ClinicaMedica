using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaMedica.Core.Entidades;
using ClinicaMedica.Core.Repositorios;
using MediatR;

namespace ClinicaMedica.Application.Commands.Servicos.CreateServico
{
	public class CreateServicoCommandHandler : IRequestHandler<CreateServicoCommand, int>
	{
		private readonly IServicosRepository _servicoRepository;
		public CreateServicoCommandHandler(IServicosRepository servicoRepository)
		{
			_servicoRepository = servicoRepository;
		}
		public async Task<int> Handle(CreateServicoCommand request, CancellationToken cancellationToken)
		{
			var servico = new Servico(request.NomeServico, request.Descricao, request.Preco, request.Duracao);

			await _servicoRepository.AddAsync(servico);
			await _servicoRepository.SaveChangesAsync();

			return servico.IdServico; 
		}
	}
}