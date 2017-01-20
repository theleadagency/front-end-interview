using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

namespace FrontEndInterview.Infrastructure
{
    /// <summary>
    /// Static implementation of Dependencies Resolver.
    /// </summary>
    public static class DependencyRegistrar
    {
        /// <summary>
        /// Registers dependency of the application.
        /// </summary>
        /// <param name="config">A instance of the <see cref="HttpConfiguration"/> for the application.</param>
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterApiControllers(assembly).PropertiesAutowired();
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterAssemblyTypes(assembly)
            .AsImplementedInterfaces();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}