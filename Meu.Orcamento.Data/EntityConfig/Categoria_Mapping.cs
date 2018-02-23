using Meu.Orcamento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Meu.Orcamento.Data.EntityConfig
{
    public class Categoria_Mapping : EntityTypeConfiguration<Categoria>
    {
        public Categoria_Mapping()
        {
            ToTable("Categoria");
            HasKey(c => c.CategoriaId);
            Property(c => c.Titulo).HasMaxLength(50);
            Property(c => c.Cor).HasMaxLength(25);
        }
    }
}
