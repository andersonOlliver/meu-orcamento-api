using Meu.Orcamento.Application.Interfaces.Categoria;
using Meu.Orcamento.Application.Interfaces.Lancamento;
using Meu.Orcamento.Application.Services;
using Meu.Orcamento.Data.Context;
using Meu.Orcamento.Data.Repositories;
using Meu.Orcamento.Data.UoW;
using Meu.Orcamento.Domain.Interfaces.Repositories;
using Meu.Orcamento.Domain.Interfaces.Services;
using Meu.Orcamento.Domain.Services;
using SimpleInjector;

namespace Meu.Orcamento.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            #region App
            container.Register<ICategoriaAppService, CategoriaAppService>(Lifestyle.Scoped);
            container.Register<ILancamentoAppService, LancamentoAppService>(Lifestyle.Scoped);
            #endregion

            #region Domain
            container.Register<ICategoriaService, CategoriaService>(Lifestyle.Scoped);
            container.Register<ILancamentoService, LancamentoService>(Lifestyle.Scoped);
            #endregion

            #region Infra
            container.Register<MeuOrcamentoContext>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            container.Register<ICategoriaRepository, CategoriaRepository>(Lifestyle.Scoped);
            container.Register<ILancamentoRepository, LancamentoRepository>(Lifestyle.Scoped);
            #endregion
        }
    }
}
