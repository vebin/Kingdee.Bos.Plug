using Autofac;
using System;

namespace MgSoft.K3Cloud.WebApi.DependenceInjection.Autofac
{
    public class DependenceInjection
    {
        public static void Register(ContainerBuilder builder)
        {
            Type basetype = typeof(IWebApi);
            builder.RegisterAssemblyTypes(typeof(IWebApi).Assembly)
                .Where(t => basetype.IsAssignableFrom(t) && t.IsClass)
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}