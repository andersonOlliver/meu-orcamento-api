using Meu.Orcamento.CrossCuting.Enum;
using Meu.Orcamento.Domain.Entities;

namespace Meu.Orcamento.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Meu.Orcamento.Data.Context.MeuOrcamentoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Meu.Orcamento.Data.Context.MeuOrcamentoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Categorias.AddOrUpdate(
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Alimentação", Cor = "#ff9900", TipoCategoria = TipoCategoria.Padrao},
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Lazer", Cor = "#33ffff", TipoCategoria = TipoCategoria.Padrao },
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Moradia", Cor = "#cccccc", TipoCategoria = TipoCategoria.Padrao },
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Outros", Cor = "#000000", TipoCategoria = TipoCategoria.Padrao },
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Salário", Cor = "#cc0000", TipoCategoria = TipoCategoria.Padrao },
                new Categoria() { CategoriaId = Guid.NewGuid(), Titulo = "Transporte", Cor = "#ffff00", TipoCategoria = TipoCategoria.Padrao }
            );
        }
    }
}
