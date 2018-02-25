using Meu.Orcamento.Domain.Entities;
using System;

namespace Meu.Orcamento.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, Guid>
    {
        Usuario Autenticar(Usuario usuario);
    }
}
