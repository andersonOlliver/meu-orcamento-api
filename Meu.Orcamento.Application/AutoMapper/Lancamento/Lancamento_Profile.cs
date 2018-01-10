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
        }
    }
}
