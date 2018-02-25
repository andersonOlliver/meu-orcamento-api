using System;
using Meu.Orcamento.CrossCuting.ValueObjects;

namespace Meu.Orcamento.Domain.Entities
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string SALT { get; set; }

    }
}
