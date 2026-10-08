using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    internal class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(genero => genero.Nome)
                .NotEmpty().WithMessage("Gênero deve ser informado!")
                .NotNull().WithMessage("Gênetro deve ser informado!")
                .Length(4, 50).WithMessage("Gênero deve conter entre 4 e 50 caracteres!");
        }
    }
}
