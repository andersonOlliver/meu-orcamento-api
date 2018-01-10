using AutoMapper;
using System.Linq;
using System.Reflection;

namespace Meu.Orcamento.Application.AutoMapper
{
    public static class MappingConfig
    {

        public static void RegisterMap()
        {
            var targetAssembly = Assembly.GetExecutingAssembly();
            var subtypes = targetAssembly.GetTypes().Where(t => t.Name.EndsWith("_Profile"));

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(subtypes);
            });
        }
    }
}
