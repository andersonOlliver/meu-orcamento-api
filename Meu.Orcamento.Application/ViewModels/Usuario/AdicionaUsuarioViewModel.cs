using System;
using System.ComponentModel;
using FluentValidation.Attributes;
using Meu.Orcamento.Application.Validators;

namespace Meu.Orcamento.Application.ViewModels.Usuario
{
    [Validator(typeof(AdicionaUsuarioViewModel_Validator))]
    [DisplayName("Usuario")]
    public class AdicionaUsuarioViewModel
    {
        public Guid UsuarioId { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
