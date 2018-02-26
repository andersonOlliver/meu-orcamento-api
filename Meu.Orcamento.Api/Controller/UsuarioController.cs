using System;
using System.Collections.Generic;
using System.Web.Http;
using Meu.Orcamento.Application.Interfaces.Usuario;
using Meu.Orcamento.Application.ViewModels.Usuario;

namespace Meu.Orcamento.Api.Controller
{
    //[Authorize]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        // GET: api/Usuario
        public IEnumerable<UsuarioViewModel> Get()
        {
            return _usuarioAppService.GetAll();
        }

        // GET: api/Usuario/5
        public UsuarioViewModel Get(Guid id)
        {
            return _usuarioAppService.GetById<UsuarioViewModel>(id);
        }

        // POST: api/Usuario
        public UsuarioViewModel Post([FromBody]AdicionaUsuarioViewModel usuario)
        {
            return _usuarioAppService.AdicionaUsuario(usuario);
        }

        // PUT: api/Usuario/5
        public UsuarioViewModel Put(Guid id, [FromBody]UsuarioViewModel usuario)
        {
            return _usuarioAppService.Update(usuario);
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
