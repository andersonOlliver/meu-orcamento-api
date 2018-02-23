using Meu.Orcamento.Application.ViewModels.Categoria;
using System;

namespace Meu.Orcamento.Application.Interfaces.Categoria
{
    public interface ICategoriaAppService : IAppService<AdicionaCategoriaViewModel, CategoriaViewModel, CategoriaViewModel, Guid>
    {
    }
}
