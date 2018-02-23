using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Meu.Orcamento.Application.ViewModels.Categoria
{
    public class AdicionaCategoriaViewModel
    {
        public Guid CategoriaId { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }
    }
}
