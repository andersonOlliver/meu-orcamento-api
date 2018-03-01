using FluentValidation;
using Meu.Orcamento.Application.Helpers;
using Meu.Orcamento.Application.ViewModels.Lancamento;

namespace Meu.Orcamento.Application.Validators.Lancamento
{
    public class AdicionaLancamentoViewModel_Validator : AbstractValidator<AdicionaLancamentoViewModel>
    {
        public AdicionaLancamentoViewModel_Validator()
        {
            RuleFor(l => l.TipoLancamento).NotNull().WithMessage(string.Format(Mensagens.CampoObrigatório, "TipoLancamento"));
            RuleFor(l => l.Valor).NotNull().WithMessage(string.Format(Mensagens.CampoObrigatório, "Valor"));
            RuleFor(l => l.DataLancamento).NotNull().WithMessage(string.Format(Mensagens.CampoObrigatório, "DataLancamento"));

        }
    }
}
