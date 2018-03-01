using Meu.Orcamento.Domain.Entities;
using Meu.Orcamento.Domain.Interfaces.Services;
using Meu.Orcamento.Domain.SharedTest;
using SimpleInjector.Lifestyles;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Meu.Orcamento.Domain.Test
{
    [ExcludeFromCodeCoverage]
    public class UsuarioServiceTest
    {
        [Fact]
        public void Ao_inserir_usuario_devera_adicionar_categorias_padrao()
        {
            var container = SimpleInjectorResolver.GetAutoMockingContainer();

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var usuarioService = container.GetInstance<IUsuarioService>();

                var usuario = new Usuario()
                {
                    UsuarioId = Guid.NewGuid(),
                    PrimeiroNome = "Anderson",
                    UltimoNome = "Oliveira",
                    Email = "anderson@email.com",
                    Senha = "123456"
                };

                var usuarioResult = usuarioService.Add(usuario);

                Assert.NotNull(usuarioResult.Categorias);
            }
        }

        [Fact]
        public void Ao_inserir_usuario_senha_devera_ser_criptografada()
        {
            var container = SimpleInjectorResolver.GetAutoMockingContainer();

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var usuarioService = container.GetInstance<IUsuarioService>();

                var usuario = new Usuario()
                {
                    UsuarioId = Guid.NewGuid(),
                    PrimeiroNome = "Anderson",
                    UltimoNome = "Oliveira",
                    Email = "anderson@email.com",
                    Senha = "123456"
                };
                var senha = usuario.Senha;

                var usuarioResult = usuarioService.Add(usuario);

                Assert.NotEqual(usuarioResult.Senha, senha);
                Assert.NotEmpty(usuarioResult.SALT);
            }
        }

        [Fact]
        public void Ao_autenticar_se_usuario_nao_existir_devera_retornar_nulo()
        {
            var container = SimpleInjectorResolver.GetAutoMockingContainer();

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var usuarioService = container.GetInstance<IUsuarioService>();

                var usuario = new Usuario()
                {
                    Email = "email@email.com",
                    Senha = "email"
                };

                var usuarioAutenticado = usuarioService.Autenticar(usuario);

                Assert.Null(usuarioAutenticado);
            }
        }
    }
}
