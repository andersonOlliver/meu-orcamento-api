using AutoMapper;
using Meu.Orcamento.Application.ViewModels.Usuario;
using Meu.Orcamento.Domain.Entities;
using System;

namespace Meu.Orcamento.Application.AutoMapper
{
    public class Usuario_Profile : Profile
    {
        public Usuario_Profile()
        {
            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(dest => dest.NomeCompleto,
                    opts => opts.MapFrom(src => $"{src.PrimeiroNome} {src.UltimoNome}"))
                .ReverseMap();

            CreateMap<Usuario, AdicionaUsuarioViewModel>().ReverseMap()
                .ForMember(dest => dest.UsuarioId,
                    opts => opts.MapFrom(src => Guid.NewGuid()));

            CreateMap<Usuario, AutenticaUsuarioViewModel>().ReverseMap();

            CreateMap<AdicionaUsuarioViewModel, UsuarioViewModel>();
        }
    }
}
