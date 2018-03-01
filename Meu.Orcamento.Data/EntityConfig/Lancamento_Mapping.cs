using System;
using Meu.Orcamento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Meu.Orcamento.Data.EntityConfig
{
    public class Lancamento_Mapping : EntityTypeConfiguration<Lancamento>
    {
        public Lancamento_Mapping()
        {
            ToTable("Lancamento");

            HasKey(l => l.LancamentoId);

            Property(l => l.Descricao)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Descricao");

            Property(l => l.TipoLancamento)
                .IsRequired();

            HasRequired<Usuario>(l => l.Usuario)
                .WithMany(u => u.Lancamentos)
                .HasForeignKey<Guid>(l => l.UsuarioId);

            HasRequired<Categoria>(l => l.Categoria)
                .WithMany(c => c.Lancamentos)
                .HasForeignKey<Guid>(l => l.CategoriaId);
        }
    }
}
