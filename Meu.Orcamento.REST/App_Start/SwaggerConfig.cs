using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Description;
using WebActivatorEx;
using Meu.Orcamento.REST;
using Swashbuckle.Application;
using Swashbuckle.Swagger;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Meu.Orcamento.REST
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Assembly thisAssembly = typeof(SwaggerConfig).Assembly;

            config.EnableSwagger(c =>
            {
                c.BasicAuth("basic").Description("Bearer Token Authentication");
                c.OperationFilter<AddRequireHeaderParameter>();

                c.SingleApiVersion("v1", "MeuOrçamento");
            })
            .EnableSwaggerUi(c =>
            {

            });
        }
    }

    public class AddRequireHeaderParameter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                type = "string",
                //required = true
            });
        }
    }
}
