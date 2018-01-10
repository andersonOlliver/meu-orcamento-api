using AutoMapper;
using Meu.Orcamento.Application.Interfaces;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu.Orcamento.Data.UoW;

namespace Meu.Orcamento.Application.Services
{
    public class AppService<C, R, U, K, P> : ApplicationService, IAppService<C, R, U, K>
    {
        private readonly IService<P, K> _service;

        public AppService(IService<P, K> service, IUnitOfWork uow) : base(uow)
        {
            _service = service;
        }

        public C Add(C obj)
        {
            var p = Mapper.Map<C, P>(obj);

            BeginTransaction();
            var pReturn = _service.Add(p);
            Commit();
            obj = Mapper.Map<P, C>(pReturn);
            return obj;
        }

        public void Dispose()
        {
            _service.Dispose();
        }

        public IEnumerable<R> GetAll()
        {
            var t = _service.GetAll();
            if(t != null)
            {
                var tViewModel = Mapper.Map<IEnumerable<P>, IEnumerable<R>>(t);
                return tViewModel;
            }

            return null;
        }

        public TReturn GetById<TReturn>(K id)
        {
            var t = _service.GetById(id);
            
            var tViewModel = Mapper.Map<P, TReturn>(t);
            return tViewModel;
        }

        public void Remove(K id)
        {
            var entity = _service.GetById(id);
            BeginTransaction();
            _service.Remove(entity);
            Commit();
        }

        public U Update(U obj)
        {
            var p = Mapper.Map<U, P>(obj);
            BeginTransaction();
            _service.Update(p);
            Commit();
            return obj;
        }
    }
}
