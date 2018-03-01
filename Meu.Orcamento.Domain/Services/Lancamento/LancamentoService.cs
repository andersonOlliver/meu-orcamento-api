using System;
using System.Collections.Generic;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Services;
using Meu.Orcamento.Domain.Interfaces.Repositories;

namespace Meu.Orcamento.Domain.Services
{
    public class LancamentoService : Service<Lancamento, Guid>, ILancamentoService
    {
        private readonly ILancamentoRepository _repository;

        public LancamentoService(ILancamentoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Lancamento> GetLancamentosMensalUsuario(Guid usuarioId, int? mes, int? ano)
        {

            if (mes == 0 || ano == 0)
            {
                var data = DateTime.Now;
                mes = data.Month;
                ano = data.Year;
            }

            return _repository.GetLancamentosMensalUsuario(usuarioId, (int)mes, (int)ano);
        }
    }
}
