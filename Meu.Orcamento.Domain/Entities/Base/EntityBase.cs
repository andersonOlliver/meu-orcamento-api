using System;

namespace Meu.Orcamento.Domain.Entities.Base
{
    public class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
