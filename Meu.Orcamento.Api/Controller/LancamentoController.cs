using System;
using System.Collections.Generic;
using System.Web.Http;
using Meu.Orcamento.Application.Interfaces.Lancamento;
using Meu.Orcamento.Application.ViewModels.Lancamento;

namespace Meu.Orcamento.API.Controllers
{
    public class LancamentoController : ApiController
    {

        private readonly ILancamentoAppService _lancamentoAppService;

        public LancamentoController(ILancamentoAppService lancamentoAppService)
        {
            _lancamentoAppService = lancamentoAppService;
        }

        // GET: api/Lancamento
        public IEnumerable<LancamentoViewModel> Get()
        {
            return _lancamentoAppService.GetAll();
        }

        // GET: api/Lancamento/5
        public LancamentoViewModel Get(Guid id)
        {
            return _lancamentoAppService.GetById<LancamentoViewModel>(id);
        }

        // POST: api/Lancamento
        public AdicionaLancamentoViewModel Post([FromBody]AdicionaLancamentoViewModel value)
        {
            return _lancamentoAppService.Add(value);
        }

        // PUT: api/Lancamento/5
        public LancamentoViewModel Put(Guid id, [FromBody]LancamentoViewModel value)
        {
            return _lancamentoAppService.Update(value);
        }

        // DELETE: api/Lancamento/5
        public void Delete(int id)
        {
        }
    }
}
