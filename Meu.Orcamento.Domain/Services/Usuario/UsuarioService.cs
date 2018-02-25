using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;

namespace Meu.Orcamento.Domain.Services
{
    public class UsuarioService : Service<Usuario, Guid>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Usuario Autenticar(Usuario usuario)
        {
            return _repository.Autenticar(usuario);
        }
    }
}
