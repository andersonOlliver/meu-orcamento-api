using Meu.Orcamento.Data.Context;
using System;

namespace Meu.Orcamento.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeuOrcamentoContext _context;
        private bool _disposed;

        public UnitOfWork(MeuOrcamentoContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); 
        }
    }
}
