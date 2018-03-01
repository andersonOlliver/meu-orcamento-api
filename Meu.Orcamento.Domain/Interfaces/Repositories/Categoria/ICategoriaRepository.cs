using Meu.Orcamento.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Meu.Orcamento.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepository<Categoria, Guid>
    {
        IEnumerable<Categoria> GetCategoriasDefault();
    }
}
