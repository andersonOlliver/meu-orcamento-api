using System;
using System.Collections.Generic;

namespace Meu.Orcamento.Domain.Interfaces.Services
{
    public interface IService<P, K> : IDisposable
    {
        P Add(P obj);

        P GetById(K id);

        IEnumerable<P> GetAll();

        P Update(P obj);

        void Remove(P obj);

    }
}
