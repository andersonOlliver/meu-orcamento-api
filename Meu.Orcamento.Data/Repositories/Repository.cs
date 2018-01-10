using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Meu.Orcamento.Data.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {

        protected MeuOrcamentoContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(MeuOrcamentoContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            var objReturn = DbSet.Add(obj);
            return objReturn;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(TKey id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Func<TEntity, bool> predicate)
        {
            DbSet.Where(predicate).ToList()
                .ForEach(del => DbSet.Remove(del));
        }

        public TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }
    }
}
