using SimpleInjector;
using System;
using Meu.Orcamento.IoC;
using SimpleInjector.Lifestyles;

namespace Meu.Orcamento.Domain.SharedTest
{
    public class SimpleInjectorResolver
    {

        public static Container GetAutoMockingContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            BootStrapper.RegisterServices(container);
            container.Verify();
            
            return container;
        }
    }
}
