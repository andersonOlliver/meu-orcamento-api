using System;
using System.Collections.Generic;

namespace Meu.Orcamento.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            this.Categorias = new HashSet<Categoria>();
        }

        public Guid UsuarioId { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string SALT { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
