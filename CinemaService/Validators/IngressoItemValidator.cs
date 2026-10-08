using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(i => i.Assento)
                .GreaterThan(0).WithMessage("Assento deve ser maior que zero!");

            RuleFor(i => i.Fileira)
                .NotEmpty().WithMessage("Fileira deve ser informada!")
                .NotNull().WithMessage("Fileira deve ser informada!");

        }
    }
}
