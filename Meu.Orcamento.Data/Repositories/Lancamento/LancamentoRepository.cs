using System;
using System.Collections.Generic;
using System.Linq;
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
        

        public IEnumerable<Lancamento> GetLancamentosMensalUsuario(Guid usuarioId, int mes, int ano)
        {
            return DbSet.Where(l =>
                    l.UsuarioId == usuarioId && l.DataLancamento.Year == ano && l.DataLancamento.Month == mes)
                .ToList();
        }
    }
}
