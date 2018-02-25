using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using System;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using Meu.Orcamento.CrossCuting.Criptografia;

namespace Meu.Orcamento.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario, Guid>, IUsuarioRepository
    {
        public UsuarioRepository(MeuOrcamentoContext context) : base(context)
        {
        }

        public override Usuario Add(Usuario usuario)
        {
            var salt = CriptografiaCrossCuting.GeraRandom();

            string senhaHash = CriptografiaCrossCuting.GeraHashSHA256(usuario.Senha + salt);

            usuario.Senha = senhaHash;
            usuario.SALT = salt;

            var objReturn = DbSet.Add(usuario);
            return objReturn;
        }

        public Usuario Autenticar(Usuario usuario)
        {
            var usuarioResult = DbSet.FirstOrDefault(u => u.Email == usuario.Email);

            if (usuarioResult != null)
            {
                var senhaHash = CriptografiaCrossCuting.GeraHashSHA256(usuario.Senha + usuarioResult.SALT);

                if (senhaHash == usuarioResult.Senha)
                {
                    return usuarioResult;
                }
            }

            return null;
        }
    }
}
