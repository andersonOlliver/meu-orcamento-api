using Meu.Orcamento.Application.Interfaces.Usuario;
using Meu.Orcamento.Application.ViewModels.Usuario;
using Meu.Orcamento.Data.UoW;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;
using AutoMapper;

namespace Meu.Orcamento.Application.Services
{
    public class UsuarioAppService : AppService<AdicionaUsuarioViewModel, UsuarioViewModel, UsuarioViewModel, Guid, Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _service;

        public UsuarioAppService(IUsuarioService service, IUnitOfWork uow) : base(service, uow)
        {
            this._service = service;
        }


        public UsuarioViewModel AdicionaUsuario(AdicionaUsuarioViewModel usuario)
        {
            var t = base.Add(usuario);
            return Mapper.Map<AdicionaUsuarioViewModel, UsuarioViewModel>(t);
        }

        public UsuarioViewModel Autentica(AutenticaUsuarioViewModel usuarioViewModel)
        {
            var usuario = Mapper.Map<AutenticaUsuarioViewModel, Usuario>(usuarioViewModel);
            usuario = _service.Autenticar(usuario);

            if (usuario != null)
            {
                return Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            }

            return null;
        }
    }
}
