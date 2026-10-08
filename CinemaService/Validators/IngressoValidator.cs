using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.Documento)
                .NotEmpty().WithMessage("Documento deve ser informado!")
                .NotNull().WithMessage("Documento deve ser informado!")
                .Length(11, 20).WithMessage("Documento deve conter entre 11 e 20 caracteres!");

            RuleFor(i => i.Secao)
                .NotEmpty().WithMessage("Sessão deve ser informada!")
                .NotNull().WithMessage("Sessão deve ser informada!");

            RuleFor(i => i.DataCompra)
                .NotEmpty().WithMessage("Data da compra deve ser informada!")
                .NotNull().WithMessage("Data da compra deve ser informada!");

            RuleFor(i => i.FormaPagamento)
                .NotEmpty().WithMessage("Forma de pagamento deve ser informada!")
                .NotNull().WithMessage("Forma de pagamento deve ser informada!");

            RuleFor(i => i.ValorTotal)
                .GreaterThan(0).WithMessage("Valor total deve ser maior que zero!");

            RuleFor(i => i.IngressoItens)
                .NotNull().WithMessage("Ingresso deve possuir itens!")
                .Must(list => list != null && list.Count > 0).WithMessage("Ingresso deve possuir ao menos um item!");
        }
    }
}
