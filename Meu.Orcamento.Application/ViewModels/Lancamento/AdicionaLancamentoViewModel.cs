using Meu.Orcamento.CrossCuting.Enum;
using System;
using FluentValidation.Attributes;
using Meu.Orcamento.Application.Validators.Lancamento;

namespace Meu.Orcamento.Application.ViewModels.Lancamento
{
    [Validator(AdicionaLancamentoViewModel_Validator)]
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
