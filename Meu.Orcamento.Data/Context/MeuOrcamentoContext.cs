using Meu.Orcamento.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;

namespace Meu.Orcamento.Data.Context
{
    public class MeuOrcamentoContext : DbContext
    {
        public MeuOrcamentoContext()
            :base("MeuOrcamentoConnection")
        {

        }

        #region Entities

        public DbSet<Lancamento> Lancamentos{ get; set; }

        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            Configuration.LazyLoadingEnabled = true;

            var targetAssembly = Assembly.GetExecutingAssembly();
            var subtypes = targetAssembly.GetTypes()
                .Where(t => t.Name.EndsWith("_Mapping"));

            foreach (var item in subtypes)
            {
                dynamic configurationInstance = Activator.CreateInstance(item);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(e => e.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(e => e.HasMaxLength(100));
        }
        
    }
}
