using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace Meu.Orcamento.Domain.Services
{
    public class UsuarioService : Service<Usuario, Guid>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly ICategoriaRepository _categoriaRepository;

        public UsuarioService(IUsuarioRepository repository, ICategoriaRepository categoriaRepository) : base(repository)
        {
            _repository = repository;
            _categoriaRepository = categoriaRepository;
        }

        public Usuario Autenticar(Usuario usuario)
        {
            return _repository.Autenticar(usuario);
        }

        public override Usuario Add(Usuario obj)
        {

            var usuario =  base.Add(obj);
            var categorias = _categoriaRepository.GetCategoriasDefault();

            if (categorias.Any()) { 
                categorias.ToList().ForEach(categoria =>
                {
                    usuario.Categorias.Add(categoria);
                });
            }

            return usuario;
        }
    }
}
