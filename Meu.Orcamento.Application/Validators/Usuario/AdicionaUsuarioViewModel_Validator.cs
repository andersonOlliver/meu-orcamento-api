using FluentValidation;
using Meu.Orcamento.Application.Helpers;
using Meu.Orcamento.Application.ViewModels.Usuario;

namespace Meu.Orcamento.Application.Validators
{
    public class AdicionaUsuarioViewModel_Validator : AbstractValidator<AdicionaUsuarioViewModel>
    {
        public AdicionaUsuarioViewModel_Validator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage(Mensagens.EmailObrigatorio)
                .EmailAddress().WithMessage(Mensagens.EmailInvalido);

            RuleFor(x => x.PrimeiroNome).NotNull().WithMessage(Mensagens.PrimeiroNomeObrigatorio);

            RuleFor(x => x.Senha).NotNull().WithMessage(Mensagens.SenhaObrigatoria)
                .Length(6,50).WithMessage(Mensagens.TamanhoSenha);

            RuleFor(x => x.UltimoNome).NotNull().WithMessage(Mensagens.UltimoNomeObrigatorio);
            
        }
    }
}
