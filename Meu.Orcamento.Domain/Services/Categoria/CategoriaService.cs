using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;

namespace Meu.Orcamento.Domain.Services
{
    public class CategoriaService : Service<Categoria, Guid>, ICategoriaService
    {
        public CategoriaService(ICategoriaRepository repository) : base(repository)
        {
        }
    }
}
