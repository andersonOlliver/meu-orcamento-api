using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu.Orcamento.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {

        TEntity Add(TEntity obj);

        TEntity GetById(TKey id);

        IEnumerable<TEntity> GetAll();

        void Remove(Func<TEntity, bool> predicate);

        TEntity Update(TEntity obj);

    }
}
