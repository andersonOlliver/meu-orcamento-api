﻿using System;
using Meu.Orcamento.Application.ViewModels.Categoria;
using Meu.Orcamento.CrossCuting.Enum;

namespace Meu.Orcamento.Application.ViewModels.Lancamento
{
    public class LancamentoViewModel
    {
        public Guid LancamentoId { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoLancamento TipoLancamento { get; set; }

        public DateTime DataLancamento { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}
