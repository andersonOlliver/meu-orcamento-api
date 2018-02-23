using System;
using AutoMapper;
using Meu.Orcamento.Application.ViewModels.Lancamento;
using Meu.Orcamento.Domain.Entities;

namespace Meu.Orcamento.Application.AutoMapper
{
    public class Lancamento_Profile : Profile
    {

        public Lancamento_Profile()
        {
            CreateMap<Lancamento, LancamentoViewModel>().ReverseMap();

            CreateMap<Lancamento, AdicionaLancamentoViewModel>().ReverseMap()
                .ForMember(dest => dest.LancamentoId,
                    opts => opts.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.DataLancamento,
                    opts => opts.MapFrom(src => src.DataLancamento != DateTime.MinValue ? src.DataLancamento : DateTime.Now));
        }
    }
}
