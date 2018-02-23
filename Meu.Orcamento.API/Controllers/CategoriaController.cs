using Meu.Orcamento.Application.Interfaces.Categoria;
using Meu.Orcamento.Application.ViewModels.Categoria;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Meu.Orcamento.API.Controllers
{
    public class CategoriaController : ApiController
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        // GET: api/Categoria
        public IEnumerable<CategoriaViewModel> Get()
        {
            return _categoriaAppService.GetAll();
        }

        // GET: api/Categoria/5
        public CategoriaViewModel Get(Guid id)
        {
            return _categoriaAppService.GetById<CategoriaViewModel>(id);
        }

        // POST: api/Categoria
        public AdicionaCategoriaViewModel Post([FromBody]AdicionaCategoriaViewModel value)
        {
            return _categoriaAppService.Add(value);
        }

        // PUT: api/Categoria/5
        public CategoriaViewModel Put(Guid id, [FromBody]CategoriaViewModel value)
        {
            return _categoriaAppService.Update(value);
        }

        // DELETE: api/Categoria/5
        public void Delete(Guid id)
        {
            _categoriaAppService.Remove(id);
        }
    }
}
