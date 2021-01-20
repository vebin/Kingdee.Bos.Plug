using Autofac;
using MgSoft.Component;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MgSoft.Log.MgSerilog.Autofac
{
    /// <summary>
    /// Serilog日志
    /// </summary>
    public class LogMgSerilogComponent : MgComponent
    {
        public override void Register(object builder)
        {
            ContainerBuilder containerBuilder = builder as ContainerBuilder;
            if (containerBuilder == null)
            {
                throw new MgException("builder need type is ContainerBuilder");
            }
            RegisterLog(containerBuilder);
            containerBuilder.RegisterType<MgSerilogger>().As<IMgLogger>();
            containerBuilder.RegisterType<MgSerilog>().As<IMgSerilog>(); 

        }

        private static void RegisterLog(ContainerBuilder builder)
        {
            var configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json")
                                    .Build();
            var  test = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
            builder.Register<Serilog.ILogger>((c, p) =>
            {
                return new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
            }).SingleInstance();
        }
    }
}
