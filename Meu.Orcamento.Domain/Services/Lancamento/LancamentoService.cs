using System;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Services;
using Meu.Orcamento.Domain.Interfaces.Repositories;

namespace Meu.Orcamento.Domain.Services
{
    public class LancamentoService : Service<Lancamento, Guid>, ILancamentoService
    {
        public LancamentoService(ILancamentoRepository repository) : base(repository)
        {
        }
    }
}
