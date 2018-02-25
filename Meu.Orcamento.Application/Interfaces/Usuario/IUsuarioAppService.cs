using Meu.Orcamento.Application.ViewModels.Usuario;
using System;

namespace Meu.Orcamento.Application.Interfaces.Usuario
{
    public interface IUsuarioAppService : IAppService<AdicionaUsuarioViewModel, UsuarioViewModel, UsuarioViewModel, Guid>
    {
        UsuarioViewModel AdicionaUsuario(AdicionaUsuarioViewModel usuario);

        UsuarioViewModel Autentica(AutenticaUsuarioViewModel usuario);
    }
}
