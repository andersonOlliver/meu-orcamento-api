using System;
using System.Collections.Generic;

namespace Meu.Orcamento.Application.Interfaces
{
    public interface IAppService<C, R, U, K> : IDisposable
    {

        C Add(C obj);

        TReturn GetById<TReturn>(K id);

        IEnumerable<R> GetAll();

        U Update(U obj);

        void Remove(K id);
    }
}
