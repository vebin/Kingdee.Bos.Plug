using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelComponent : ImportComponent, IExcelComponent
    {

        public abstract Type SchemeType { get; }

        public virtual List<ExcelTaskTypeInfo> GetAllExcelTaskType(IContainer container)
        {
            List<ExcelTaskTypeInfo> result = new List<ExcelTaskTypeInfo>();
            var excelTaskManagerType = typeof(IExcelTaskManager);
            var excelTaskManagers = this.GetType().Assembly.GetTypes().Where(p => excelTaskManagerType.IsAssignableFrom(p));
            foreach (var excelTaskManager in excelTaskManagers)
            {
                var target = container.ResolveNamed<IExcelTaskManager>(excelTaskManager.FullName);
                result.Add(new ExcelTaskTypeInfo()
                {
                    ComponentName = Name,
                    ComponentDescribe = Describe,
                    ComponentTitle = Title,
                    TaskManagerName = target.Name,
                    TaskManagerTitle = target.Title,
                    TaskManagerDescribe = target.Describe
                });
            }
            return result;
        }

        public virtual IExcelScheme GetScheme(IContainer container)
        {
            return container.Resolve(SchemeType) as IExcelScheme;
        }

        public override void Register(object builder)
        {
            ContainerBuilder containerBuilder = builder as ContainerBuilder;
            if (containerBuilder == null) throw new ArgumentException("builder need type is ContainerBuilder");

            containerBuilder.RegisterType(SchemeType);
            registerExcelTaskManager(containerBuilder);

            OnRegister(containerBuilder);
        }

        private void registerExcelTaskManager(ContainerBuilder containerBuilder)
        {
            var excelTaskManagerType = typeof(IExcelTaskManager);
            var excelTaskManagers = this.GetType().Assembly.GetTypes().Where(p => excelTaskManagerType.IsAssignableFrom(p)).ToList();
            excelTaskManagers.ForEach(p => containerBuilder.RegisterType(p).Named(p.FullName, excelTaskManagerType).InstancePerLifetimeScope());
        }

        public virtual void OnRegister(ContainerBuilder containerBuilder)
        {

        }
    }
}
