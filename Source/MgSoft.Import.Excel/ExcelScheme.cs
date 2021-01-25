using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelScheme: Scheme, IExcelScheme
    {
        private ILifetimeScope lifetimeScope;

        protected SortedList<int, string> orderTaskManager { get; set; }

        protected ExcelScheme(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public abstract FileExcelTaskTypeInfo Match(string filePath);

        public AggregateExcelMessage Check(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
            foreach(var fileExcelTaskType in fileExcelTaskTypes)
            {
                check(fileExcelTaskType, aggregateExcelMessage);
            }
            return aggregateExcelMessage;
        }

        private void check(FileExcelTaskTypeInfo fileExcelTaskType,AggregateExcelMessage aggregateExcelMessage)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            excelTaskManager.SetExcelFilePath(fileExcelTaskType.FilePath);
            excelTaskManager.InitAndCheck(aggregateExcelMessage);
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

        private void import(FileExcelTaskTypeInfo fileExcelTaskType,AggregateExcelMessage aggregateExcelMessage)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            excelTaskManager.SetExcelFilePath(fileExcelTaskType.FilePath);
            excelTaskManager.Do(aggregateExcelMessage);
        }

        public List<FileExcelTaskTypeInfo> Match(List<string> filePaths)
        {
            List<FileExcelTaskTypeInfo> result = new List<FileExcelTaskTypeInfo>();
            foreach (var filePath in filePaths)
            {
                var fileExcelTaskType = Match(filePath);
                if (fileExcelTaskType == null) result.Add(fileExcelTaskType);
            }
            return result;
        }

        public abstract void DoTaskManagers(List<FileExcelTaskTypeInfo> fileExcelTaskTypes, AggregateExcelMessage aggregateExcelMessage);
    }
}
