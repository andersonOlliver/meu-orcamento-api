using Meu.Orcamento.CrossCuting.Enum;
using System;

namespace Meu.Orcamento.Application.ViewModels.Lancamento
{
    public class AdicionaLancamentoViewModel
    {
        public Guid LancamentoId { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoLancamento TipoLancamento { get; set; }

        public DateTime DataLancamento { get; set; }

        public Guid CategoriaId { get; set; }
    }
}
