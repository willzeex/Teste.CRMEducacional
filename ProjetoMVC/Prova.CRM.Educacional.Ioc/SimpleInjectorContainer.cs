namespace Prova.CRM.Educacional.Ioc
{
    using Domain.Interfaces.Services;
    using Infra.Services;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Reflection;
    using System.Web.Mvc;

    public class SimpleInjectorContainer
    {
        private static readonly Container _container = new Container();

        public static void RegisterSerices()
        {
            _container.Register<IIntegracaoService, IntegracaoService>();
            _container.Register<IEnsalamentoService, EnsalamentoService>();

            _container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(
                    new SimpleInjectorDependencyResolver(_container)
                );
        }
    }
}
