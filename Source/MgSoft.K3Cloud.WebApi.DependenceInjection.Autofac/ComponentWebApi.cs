using MgSoft.Component;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MgSoft.K3Cloud.WebApi.Services;

namespace MgSoft.K3Cloud.WebApi.DependenceInjection.Autofac
{
    public class ComponentWebApi : MgComponent
    {
        private Action<ApiServerInfo> cfgAction;

        public override void Register(object builder)
        {
            ContainerBuilder containerBuilder = builder as ContainerBuilder;
            if (containerBuilder == null) throw new ArgumentException("builder type must ContainerBuilder");

            Type basetype = typeof(IApi);
            containerBuilder.RegisterAssemblyTypes(typeof(IApi).Assembly)
                .Where(t => basetype.IsAssignableFrom(t) && t.IsClass)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            containerBuilder.RegisterType<LoginServices>().As<ILoginServices>();

            containerBuilder.RegisterType<ApiServerInfo>()
               .OnActivating(p =>
               {
                   ApiServerInfo apiServerInfo = new ApiServerInfo();
                   cfgAction.Invoke(apiServerInfo);
                   p.ReplaceInstance(apiServerInfo);
               });

            containerBuilder.RegisterType(this.GetType()).OnActivating(p => p.ReplaceInstance(this));
        }
        public void Config(Action<ApiServerInfo> cfg)
        {
            cfgAction = cfg;
        }
    }
}
