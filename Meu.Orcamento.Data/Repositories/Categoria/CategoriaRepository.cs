using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using System;

namespace Meu.Orcamento.Data.Repositories
{
    public class CategoriaRepository: Repository<Categoria, Guid>, ICategoriaRepository
    {
        public CategoriaRepository(MeuOrcamentoContext context) : base(context)
        {
        }
    }
}
