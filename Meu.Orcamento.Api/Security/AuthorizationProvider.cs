using Meu.Orcamento.Application.Interfaces.Usuario;
using Meu.Orcamento.Application.ViewModels.Usuario;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Security;

namespace Meu.Orcamento.Api.Security
{

    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        private readonly Container _container;

        public AuthorizationProvider(Container container)
        {
            this._container = container;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {

            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            using (AsyncScopedLifestyle.BeginScope(_container))
            {

                try
                {
                    IUsuarioAppService service = _container.GetInstance<IUsuarioAppService>();


                    AutenticaUsuarioViewModel usuarioRequest = new AutenticaUsuarioViewModel();
                    usuarioRequest.Email = context.UserName;
                    usuarioRequest.Senha = context.Password;

                    var usuario = service.Autentica(usuarioRequest);

                    if (usuario == null)
                    {
                        context.SetError("invalid_grant", "E-mail ou senha incorreta.");
                        return;
                    }

                    
                    identity.AddClaim(new Claim("Usuario", JsonConvert.SerializeObject(usuario)));


                    var principal = new GenericPrincipal(identity, new string[] { });

                    Thread.CurrentPrincipal = principal;

                    context.Validated(identity);
                }
                catch (Exception ex)
                {
                    context.SetError("invalid_grant", ex.Message);
                    return;
                }
            }
        }

        public override async Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var originalClient = context.Ticket.Properties.Dictionary["as:client_id"];
            var currentClient = context.OwinContext.Get<string>("as:client_id");

            if (originalClient != currentClient)
            {
                context.Rejected();
                return;
            }

            var newId = new ClaimsIdentity(context.Ticket.Identity);
            newId.AddClaim(new Claim("newClaim", "refreshToken"));

            var newTicket = new AuthenticationTicket(newId, context.Ticket.Properties);
            context.Validated(newTicket);
        }
    }
}