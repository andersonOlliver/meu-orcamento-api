using System;
using System.Collections.Generic;
using Meu.Orcamento.Domain.Entities;

namespace Meu.Orcamento.Domain.Interfaces.Repositories
{
    public interface ILancamentoRepository: IRepository<Lancamento, Guid>
    {
        IEnumerable<Lancamento> GetLancamentosMensalUsuario(Guid usuarioId, int mes, int ano);
    }
}
