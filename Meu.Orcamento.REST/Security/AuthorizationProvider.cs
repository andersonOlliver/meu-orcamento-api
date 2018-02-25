using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Meu.Orcamento.Application.Interfaces.Usuario;
using Meu.Orcamento.Application.ViewModels.Usuario;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using SimpleInjector;

namespace Meu.Orcamento.REST.Security
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        //private readonly Container _container;

        //public AuthorizationProvider(Container container)
        //{
        //    this._container = container;
        //}

        //public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        //{
        //    context.Validated();
        //}

        //public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        //{
        //    try
        //    {
        //        IUsuarioAppService service = _container.GetInstance<IUsuarioAppService>();

        //        AutenticaUsuarioViewModel usuarioRequest = new AutenticaUsuarioViewModel();
        //        usuarioRequest.Email = context.UserName;
        //        usuarioRequest.Senha = context.Password;

        //        var usuario = service.Autentica(usuarioRequest);

        //        if (usuario == null)
        //        {
        //            context.SetError("invalid_grant", "E-mail ou senha incorreta.");
        //            return;
        //        }

        //        var identity = new ClaimsIdentity(context.Options.AuthenticationType);
        //        identity.AddClaim(new Claim("Usuario", JsonConvert.SerializeObject(usuario)));

        //        var principal = new GenericPrincipal(identity, new string[] { });

        //        Thread.CurrentPrincipal = principal;

        //        context.Validated(identity);
        //    }
        //    catch (Exception ex)
        //    {
        //        context.SetError("invalid_grant", ex.Message);
        //        return;
        //    }
        //}
    }
}