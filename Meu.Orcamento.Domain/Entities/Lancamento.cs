﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu.Orcamento.Domain.Entities
{
    public class Lancamento
    {
        public int LancamentoId { get; set; }

        public string Description { get; set; }

        public decimal Value{ get; set; }
    }
}
