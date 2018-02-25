using Meu.Orcamento.Domain.Entities;
using System;

namespace Meu.Orcamento.Domain.Interfaces.Services
{
    public interface IUsuarioService : IService<Usuario, Guid>
    {
        Usuario Autenticar(Usuario usuario);
    }
}
