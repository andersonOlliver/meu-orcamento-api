using System;

namespace Meu.Orcamento.Domain.Entities
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }

        public Categoria()
        {
            this.CategoriaId = Guid.NewGuid();
        }
    }
}
