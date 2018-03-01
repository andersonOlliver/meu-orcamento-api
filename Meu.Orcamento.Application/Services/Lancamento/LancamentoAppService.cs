using System;
using System.Collections.Generic;
using AutoMapper;
using Meu.Orcamento.Application.Interfaces.Lancamento;
using Meu.Orcamento.Application.ViewModels.Lancamento;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Data.UoW;
using Meu.Orcamento.Domain.Interfaces.Services;

namespace Meu.Orcamento.Application.Services
{
    public class LancamentoAppService : AppService<AdicionaLancamentoViewModel, LancamentoViewModel, LancamentoViewModel, Guid, Lancamento>, ILancamentoAppService
    {
        private readonly ILancamentoService _service;

        public LancamentoAppService(ILancamentoService service, IUnitOfWork uow) : base(service, uow)
        {
            _service = service;
        }

        public IEnumerable<LancamentoViewModel> GetLancamentosMensalUsuario(Guid usuarioId, int? mes, int? ano)
        {
            var dados = _service.GetLancamentosMensalUsuario(usuarioId, mes, ano);

            return Mapper.Map<IEnumerable<LancamentoViewModel>>(dados);
        }
    }
}
