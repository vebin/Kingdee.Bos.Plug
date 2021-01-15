using Autofac;
using Autofac.Builder;
using Autofac.Features.Scanning;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MgSoft.DependenceInjection.Autofac
{
    public static class RegisterAssemblyType
    {
        public static ContainerBuilder Register(Assembly assembly, ContainerBuilder builder)
        {
            Register(typeof(IDependency),assembly,builder).InstancePerDependency();
            Register(typeof(IPerLifetimeScope), assembly, builder).InstancePerLifetimeScope();
            Register(typeof(ISingleInstance), assembly, builder).SingleInstance();

            return builder;
        }
        private static IRegistrationBuilder<object, ScanningActivatorData, DynamicRegistrationStyle> Register(Type baseType, Assembly assembly, ContainerBuilder builder)
        {
            return builder.RegisterAssemblyTypes(assembly)
                .Where(t => baseType.IsAssignableFrom(t) && t.IsClass)
                .AsImplementedInterfaces();
        }

    }
}
