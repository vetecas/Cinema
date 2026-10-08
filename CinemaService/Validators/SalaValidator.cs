using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class SalaValidator : AbstractValidator<Sala>
    {
        public SalaValidator()
        {
            RuleFor(s => s.Capacidade)
                .GreaterThan(0).WithMessage("Capacidade deve ser maior que zero!");

            RuleFor(s => s.Numero)
                .GreaterThan(0).WithMessage("Número da sala deve ser maior que zero!");

            RuleFor(s => s.Fileiras)
                .NotEmpty().WithMessage("Fileiras deve ser informada!")
                .NotNull().WithMessage("Fileiras deve ser informada!");

            RuleFor(s => s.Assentos)
                .GreaterThan(0).WithMessage("Assentos deve ser maior que zero!");
        }
    }
}
