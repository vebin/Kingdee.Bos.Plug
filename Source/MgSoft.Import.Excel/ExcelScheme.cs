using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelScheme : Scheme, IExcelScheme
    {
        private ILifetimeScope lifetimeScope;

        protected SortedList<int, string> orderTaskManager { get; set; }

        protected ExcelScheme(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public abstract List<FileExcelTaskTypeInfo> Match(string filePath);

        public AggregateExcelMessage InitAndCheck(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage result = new AggregateExcelMessage();
            foreach (var fileExcelTaskType in fileExcelTaskTypes)
            {
                AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
                TaskManagerInfoArg taskManagerInfoArg = new TaskManagerInfoArg(null, fileExcelTaskType, aggregateExcelMessage);
                var socpe = lifetimeScope.BeginLifetimeScope();
                var excelTaskManager = socpe.ResolveNamed<IExcelTaskManager>(taskManagerInfoArg.FileExcelTaskTypeInfo.TaskManagerName);
                fileExcelTaskType.SetTaskManagerInstance(excelTaskManager);
                excelTaskManager.InitAndCheck(taskManagerInfoArg);
                result.Add(aggregateExcelMessage);
            }
            return result;
        }

        public virtual AggregateExcelMessage Import(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();

            foreach (var fileExcelTaskType in fileExcelTaskTypes)
            {
                import(fileExcelTaskType, aggregateExcelMessage);
            }
            return aggregateExcelMessage;
        }

        private void import(FileExcelTaskTypeInfo fileExcelTaskType, AggregateExcelMessage aggregateExcelMessage)
        {
            //var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            var excelTaskManager = fileExcelTaskType.TaskManager;
            TaskManagerInfoArg taskManagerInfoArg = new TaskManagerInfoArg(excelTaskManager.MgExcel, fileExcelTaskType, aggregateExcelMessage);
            excelTaskManager.Do(taskManagerInfoArg);
        }

        public List<FileExcelTaskTypeInfo> Match(List<string> filePaths)
        {
            List<FileExcelTaskTypeInfo> result = new List<FileExcelTaskTypeInfo>();
            foreach (var filePath in filePaths)
            {
                var fileExcelTaskTypes = Match(filePath);
                if (fileExcelTaskTypes.Count != 0) result.AddRange(fileExcelTaskTypes);
            }
            return result;
        }

        public abstract void DoTaskManagers(List<FileExcelTaskTypeInfo> fileExcelTaskTypes, AggregateExcelMessage aggregateExcelMessage);
    }
}
