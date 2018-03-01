using System;
using System.Collections.Generic;
using Meu.Orcamento.Application.ViewModels.Lancamento;

namespace Meu.Orcamento.Application.Interfaces.Lancamento
{
    public interface ILancamentoAppService: IAppService<AdicionaLancamentoViewModel, LancamentoViewModel, LancamentoViewModel, Guid>
    {
        IEnumerable<LancamentoViewModel> GetLancamentosMensalUsuario(Guid usuarioId, int? mes, int? ano);
    }
}
