using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(genero => genero.Nome)
                .NotEmpty().WithMessage("Gênero deve ser informado!")
                .NotNull().WithMessage("Gênero deve ser informado!")
                .Length(4, 50).WithMessage("Gênero deve conter entre 4 e 50 caracteres!");
        }
    }
}
