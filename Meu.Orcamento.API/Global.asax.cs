using Meu.Orcamento.Application.AutoMapper;
using System.Web.Http;

namespace Meu.Orcamento.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            MappingConfig.RegisterMap();
        }
    }
}
