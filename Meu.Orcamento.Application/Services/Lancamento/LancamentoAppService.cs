using Meu.Orcamento.Application.Interfaces.Lancamento;
using Meu.Orcamento.Application.ViewModels.Lancamento;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Data.UoW;
using Meu.Orcamento.Domain.Interfaces.Services;

namespace Meu.Orcamento.Application.Services
{
    public class LancamentoAppService : AppService<LancamentoViewModel, LancamentoViewModel, LancamentoViewModel, int, Lancamento>, ILancamentoAppService
    {
        
        public LancamentoAppService(ILancamentoService service, IUnitOfWork uow) : base(service, uow)
        {
        }
    }
}
