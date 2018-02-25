using FluentValidation.WebApi;
using Meu.Orcamento.Application.AutoMapper;
using Meu.Orcamento.IoC;
using Meu.Orcamento.REST.App_Start;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Web.Http;
using Meu.Orcamento.REST.Security;

namespace Meu.Orcamento.REST
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //SwaggerConfig.Register(config);

            // Configura injeção de dependencia
            var container = new Container();
            config.DependencyResolver = ConfiguraSimpleInjector(ref container, config);

            ConfigureWebApi(config);
            //ConfiguraValidacao(config);
            //ConfigureOAuth(app, container);
            //ConfiguraAutoMapper();
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            app.UseWebApi(config);
        }

        private static void ConfiguraValidacao(HttpConfiguration config)
        {
            config.Filters.Add(new ValidateModelStateFilter());
            FluentValidationModelValidatorProvider.Configure(config);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            // Remove o XML
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            //Compacta retorno de cada requisição realizada para api
            //config.MessageHandlers.Insert(0, new ServerCompressionHandler(new GZipCompressor(), new DeflateCompressor()));

            // Modifica a identação
            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Modifica a serialização
            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            Register(config);
        }

        public static void Register(HttpConfiguration config)
        {
            //add Uow action filter globally
            //config.Filters.Add(new UnitOfWorkActionFilter());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public void ConfigureOAuth(IAppBuilder app, Container container)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                //Provider = new AuthorizationProvider(container)
            };

            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }

        public void ConfiguraAutoMapper()
        {
            MappingConfig.RegisterMap();
        }

        public SimpleInjectorWebApiDependencyResolver ConfiguraSimpleInjector(ref Container container, HttpConfiguration config)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            BootStrapper.RegisterServices(container);
            container.RegisterWebApiControllers(config);
            container.Verify();
            return new SimpleInjectorWebApiDependencyResolver(container);
        }

    }
}