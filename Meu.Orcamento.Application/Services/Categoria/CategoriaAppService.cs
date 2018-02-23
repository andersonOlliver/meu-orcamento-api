using Meu.Orcamento.Application.Interfaces.Categoria;
using Meu.Orcamento.Application.ViewModels.Categoria;
using Meu.Orcamento.Data.UoW;
using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Services;
using System;

namespace Meu.Orcamento.Application.Services
{
    public class CategoriaAppService: AppService<AdicionaCategoriaViewModel, CategoriaViewModel, CategoriaViewModel, Guid, Categoria>, ICategoriaAppService
    {
        public CategoriaAppService(ICategoriaService service, IUnitOfWork uow) : base(service, uow)
        {
        }
    }
}
