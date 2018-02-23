using System;
using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;

namespace Meu.Orcamento.Data.Repositories
{
    public class LancamentoRepository : Repository<Lancamento, Guid>, ILancamentoRepository
    {
        public LancamentoRepository(MeuOrcamentoContext context) : base(context)
        {
        }
    }
}
