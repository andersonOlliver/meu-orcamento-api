using System;
using Meu.Orcamento.Application.ViewModels.Lancamento;

namespace Meu.Orcamento.Application.Interfaces.Lancamento
{
    public interface ILancamentoAppService: IAppService<AdicionaLancamentoViewModel, LancamentoViewModel, LancamentoViewModel, Guid>
    {
    }
}
