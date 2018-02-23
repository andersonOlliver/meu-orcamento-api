using System;
using AutoMapper;
using Meu.Orcamento.Application.ViewModels.Categoria;
using Meu.Orcamento.Domain.Entities;

namespace Meu.Orcamento.Application.AutoMapper
{
    public class Categoria_Profile: Profile
    {
        public Categoria_Profile()
        {
            CreateMap<Categoria, CategoriaViewModel>()
                .ReverseMap();

            CreateMap<Categoria, AdicionaCategoriaViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.CategoriaId,
                    opts => opts.MapFrom(src => Guid.NewGuid()));
        }
    }
}
