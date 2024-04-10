using ClinicaMedica.Application.DTO_s;
using FluentValidation;

namespace ClinicaMedica.Application.Validator
{
    public class CreateAnexoValidatorDTO : AbstractValidator<AnexoDTO>
    {
        public CreateAnexoValidatorDTO()
        {
            RuleFor(a => a.TipoAnexo)
                .NotEmpty()
                .WithMessage("O tipo do anexo é de preenchimento obrigatório");

            RuleFor(a => a.NomeArquivo)
                .MaximumLength(50)
                .WithMessage("Tamanho máximo do nome é de 50 caracteres!")
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome do arquivo é de preenchimento obrigatório!");

            RuleFor(a => a.Arquivo)
                .NotEmpty()
                .NotNull()
                .WithMessage("O envio do arquivo é obrigatório!");
        }
    }
}
