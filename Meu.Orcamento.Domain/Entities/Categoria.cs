using System;
using System.Collections.Generic;
using Meu.Orcamento.CrossCuting.Enum;

namespace Meu.Orcamento.Domain.Entities
{
    public class Categoria
    {

        public Categoria()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        public Guid CategoriaId { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }

        public TipoCategoria TipoCategoria { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
