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

        public abstract FileExcelTaskType Match(string filePath);

        public AggregateExcelMessage Check(List<FileExcelTaskType> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
            foreach(var fileExcelTaskType in fileExcelTaskTypes)
            {
                check(fileExcelTaskType, ref aggregateExcelMessage);
            }
            return aggregateExcelMessage;
        }

        private void check(FileExcelTaskType fileExcelTaskType,ref AggregateExcelMessage aggregateExcelMessage)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            excelTaskManager.SetExcelFilePath(fileExcelTaskType.FilePath);
            excelTaskManager.Check(ref aggregateExcelMessage);
        }

        public virtual AggregateExcelMessage Import(List<FileExcelTaskType> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
            foreach(var fileExcelTaskType in fileExcelTaskTypes)
            {
                import(fileExcelTaskType, ref aggregateExcelMessage);
            }
            return aggregateExcelMessage;
        }

        private void import(FileExcelTaskType fileExcelTaskType,ref AggregateExcelMessage aggregateExcelMessage)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            excelTaskManager.SetExcelFilePath(fileExcelTaskType.FilePath);
            excelTaskManager.Do(ref aggregateExcelMessage);
        }

        public List<FileExcelTaskType> Match(List<string> filePaths)
        {
            List<FileExcelTaskType> result = new List<FileExcelTaskType>();
            foreach (var filePath in filePaths)
            {
                var fileExcelTaskType = Match(filePath);
                if (fileExcelTaskType == null) result.Add(fileExcelTaskType);
            }
            return result;
        }

        public abstract SortedList<int, string> InitSortTaskManagers();
    }
}
