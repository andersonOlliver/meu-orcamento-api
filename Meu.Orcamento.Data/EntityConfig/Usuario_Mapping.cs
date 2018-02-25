using Meu.Orcamento.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Meu.Orcamento.Data.EntityConfig
{
    public class Usuario_Mapping : EntityTypeConfiguration<Usuario>
    {
        public Usuario_Mapping()
        {
            ToTable("Usuario");

            Property(u => u.Email)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnAnnotation("Index", 
                    new IndexAnnotation(new IndexAttribute("UK_USUARIO_EMAIL") { IsUnique = true }))
                .HasColumnName("Email");

            Property(u => u.PrimeiroNome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("PrimeiroNome");

            Property(u => u.UltimoNome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("UltimoNome");

            Property(u => u.Senha)
                .HasMaxLength(200)
                .IsRequired();

            Property(u => u.SALT)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
