using FluentValidation.Attributes;
using Meu.Orcamento.Application.Validators.Categoria;
using System;

namespace Meu.Orcamento.Application.ViewModels.Categoria
{
    [Validator(typeof(AdicionaCategoriaViewModel_Validator))]
    public class AdicionaCategoriaViewModel
    {
        public Guid CategoriaId { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }
    }
}
