using System;

namespace Meu.Orcamento.Domain.Entities
{
    public class Lancamento
    {
        public int LancamentoId { get; set; }

        public string Description { get; set; }

        public decimal Value{ get; set; }

        public DateTime DateLancamento{ get; set; }
    }
}
