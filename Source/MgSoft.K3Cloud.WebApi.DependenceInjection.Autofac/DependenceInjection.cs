using Autofac;
using Autofac.Core;
using MgSoft.K3Cloud.WebApi.Dto;
using System;

namespace MgSoft.K3Cloud.WebApi.DependenceInjection.Autofac
{
    public class DependenceInjection
    {
        public static void Register(ContainerBuilder builder, Func<IComponentContext, ApiServerInfo> cfg)
        {
            Type basetype = typeof(IApi);
            builder.RegisterAssemblyTypes(typeof(IApi).Assembly)
                .Where(t => basetype.IsAssignableFrom(t) && t.IsClass)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<ApiServerInfo>()
               .OnActivating(p => p.ReplaceInstance(cfg.Invoke(p.Context)));


        }
    }
}