using System;
using Meu.Orcamento.CrossCuting.Enum;

namespace Meu.Orcamento.Domain.Entities
{
    public class Lancamento
    {
        public Guid LancamentoId { get; set; }

        public string Descricao { get; set; }

        public decimal Valor{ get; set; }

        public TipoLancamento TipoLancamento { get; set; }

        public DateTime DataLancamento{ get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
