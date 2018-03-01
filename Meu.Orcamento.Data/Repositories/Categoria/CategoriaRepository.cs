using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Meu.Orcamento.CrossCuting.Enum;

namespace Meu.Orcamento.Data.Repositories
{
    public class CategoriaRepository: Repository<Categoria, Guid>, ICategoriaRepository
    {
        public CategoriaRepository(MeuOrcamentoContext context) : base(context)
        {
        }

        public IEnumerable<Categoria> GetCategoriasDefault()
        {
            var categorias = DbSet.Where(c => c.TipoCategoria == TipoCategoria.Padrao).ToList();
            return categorias;
        }
    }
}
