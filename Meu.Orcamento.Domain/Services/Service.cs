using Meu.Orcamento.Domain.Interfaces.Repositories;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Meu.Orcamento.Domain.Services
{
    public class Service<P, K>: IService<P, K> where P: class
    {
        private readonly IRepository<P, K> _repository;

        public Service(IRepository<P, K> repository)
        {
            _repository = repository;
        }

        public virtual P Add(P obj)
        {
            return _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<P> GetAll()
        {
            return _repository.GetAll();
        }

        public P GetById(K id)
        {
            return _repository.GetById(id);
        }

        public void Remove(P obj)
        {
            _repository.Remove(c => c.Equals(obj));
        }

        public P Update(P obj)
        {
            return _repository.Update(obj);
        }
    }
}
