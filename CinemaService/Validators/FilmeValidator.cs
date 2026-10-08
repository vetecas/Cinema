using CinemaDomain;
using FluentValidation;


namespace CinemaService.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(filme => filme.Nome)
                .NotEmpty().WithMessage("Título deve ser informado!")
                .NotNull().WithMessage("Título deve ser informado!")
                .Length(4, 50).WithMessage("Título deve conter entre 4 e 50 caracteres!");
            RuleFor(filme => filme.Duracao)
                .NotEmpty().WithMessage("Duração deve ser informada!")
                .NotNull().WithMessage("Duração deve ser informada!")
                .GreaterThan(0).WithMessage("Duração deve ser maior que zero!");
            RuleFor(filme => filme.Genero)
                .NotEmpty().WithMessage("Gênero deve ser informado!")
                .NotNull().WithMessage("Gênero deve ser informado!");
        }
    }
}
