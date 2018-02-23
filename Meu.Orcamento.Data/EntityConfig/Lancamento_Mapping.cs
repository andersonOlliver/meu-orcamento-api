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

           
        }
    }
}
