using System;

namespace Meu.Orcamento.Application.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        public Guid UsuarioId { get; set; }

        public string NomeCompleto { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

    }
}
