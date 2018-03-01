using FluentValidation;
using Meu.Orcamento.Application.Helpers;
using Meu.Orcamento.Application.ViewModels.Categoria;

namespace Meu.Orcamento.Application.Validators.Categoria
{
    public class AdicionaCategoriaViewModel_Validator : AbstractValidator<AdicionaCategoriaViewModel>
    {
        public AdicionaCategoriaViewModel_Validator()
        {
            RuleFor(c => c.Titulo).NotNull().WithMessage(Mensagens.TituloObrigatorio);
            RuleFor(c => c.Cor).NotNull().WithMessage(Mensagens.CorObrigatorio)
                .MaximumLength(15).WithMessage(string.Format(Mensagens.TamanhoMaximo, 15));
        }
    }
}
