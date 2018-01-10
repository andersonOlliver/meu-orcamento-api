using System;

namespace Meu.Orcamento.Application.ViewModels.Lancamento
{
    public class LancamentoViewModel
    {
        public int LancamentoId { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public DateTime DateLancamento { get; set; }
    }
}
