using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator()
        {
            RuleFor(s => s.Filme)
                .NotEmpty().WithMessage("Filme deve ser informado!")
                .NotNull().WithMessage("Filme deve ser informado!");

            RuleFor(s => s.Sala)
                .NotEmpty().WithMessage("Sala deve ser informada!")
                .NotNull().WithMessage("Sala deve ser informada!");

            RuleFor(s => s.Data)
                .NotEmpty().WithMessage("Data da sessão deve ser informada!")
                .NotNull().WithMessage("Data da sessão deve ser informada!");

            RuleFor(s => s.Preco)
                .GreaterThan(0).WithMessage("Preço da sessão deve ser maior que zero!");
        }
    }
}
